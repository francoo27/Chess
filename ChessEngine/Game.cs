//This file is part of Chess.
//Chess is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//Chess is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with Chess. If not, see <https://www.gnu.org/licenses/>.
namespace ChessEngine
{
    public class Game
    {
        private Player[] players = new Player[2];
        private Board board = new Board();
        private Player currentTurn;
        private GameStatus status;
        private List<Move> movesPlayed = new List<Move>();

        public string PrintBoard() => board.PrintBoard();

        public GameStatus Status
        {
            get { return status; }
            private set { status = value; }
        }

        public Player CurrentTurn
        {
            get { return currentTurn; }
            private set { currentTurn = value; }
        }

        private void SetCurrentTurn()
        {
            if (CurrentTurn == players[0])
            {
                CurrentTurn = players[1];
            }
            else
            {
                CurrentTurn = players[0];
            }
        }


        public void Initialize(Player PlayerONE, Player PlayerTWO)
        {
            players[0] = PlayerONE;
            players[1] = PlayerTWO;

            board.resetBoard();

            CurrentTurn = PlayerONE.WhiteSide ? PlayerONE : PlayerTWO;

            movesPlayed.Clear();
        }

        public bool IsEnd() => Status != GameStatus.ACTIVE;

        public bool PlayerMove(Player player, int startX,
                                    int startY, int endX, int endY)
        {
            Spot startBox = board.getBox(startX, startY);
            Spot endBox = board.getBox(endX, endY);
            Move move = new Move(player, startBox, endBox);
            return MakeMove(move, player);
        }

        private bool MakeMove(Move move, Player player)
        {
            Piece sourcePiece = move.Start.Piece;
            if (sourcePiece == null)
            {
                return false;
            }

            // VALID TURN
            if (player != currentTurn)
            {
                return false;
            }

            if (sourcePiece.White != player.WhiteSide)
            {
                return false;
            }

            // IS THE MOVE VALID
            if (!sourcePiece.CanMove(board, move.Start, move.End))
            {
                return false;
            }

            // DOES IT KILL ANYTHING
            Piece destPiece = move.End.Piece;
            if (destPiece != null)
            {
                destPiece.Killed = true;
                move.PieceKilled = destPiece;
            }

            // STORE MOVE
            movesPlayed.Add(move);

            // MOVE PIECE FROM ONE BOX TO ANOTHER
            move.End.Piece = move.Start.Piece;
            move.Start.Piece = null;

            if (destPiece != null && destPiece is King)
            {
                if (player.WhiteSide)
                {
                    Status = GameStatus.WHITE_WIN;
                }
                else
                {
                    Status = GameStatus.BLACK_WIN;
                }
            }

            // CHANGE TURN TO ANOTHER PLAYER
            SetCurrentTurn();

            return true;
        }
    }
}
