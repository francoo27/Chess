//This file is part of Chess.
//Chess is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//Chess is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with Chess. If not, see <https://www.gnu.org/licenses/>.
using ChessEngine.Pieces;

namespace ChessEngine
{
    public class King : Piece
    {
        public King(bool white) : base(white, typeof(King).Name) { }

        public override bool CanMove(Board board, Spot start, Spot end)
        {
            if (PieceMoveHelper.IsEndPieceSameColor(start.Piece, end.Piece))
                return false;

            int x = Math.Abs(start.X - end.X);
            int y = Math.Abs(start.Y - end.Y);
            // TODO: MAKE THE MOVE INVALID IF THE KINGS MOVES TO A DANGER CELL
            return (x <= 1) && (y <= 1);
        }

    }
}

