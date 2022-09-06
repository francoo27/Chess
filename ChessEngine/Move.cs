//This file is part of Chess.
//Chess is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//Chess is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with Chess. If not, see <https://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public class Move
    {
        private Player player;
        private Spot start;
        private Spot end;
        private Piece pieceMoved;
        private Piece? pieceKilled;
        private bool castlingMove = false;

        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        public Spot Start
        {
            get { return start; }
            set { start = value; }
        }

        public Spot End
        {
            get { return end; }
            set { end = value; }
        }

        public Piece? PieceMoved
        {
            get { return pieceMoved; }
            set { pieceMoved = value; }
        }
        public Piece PieceKilled
        {
            get { return pieceKilled; }
            set { pieceKilled = value; }
        }


        public Move(Player player, Spot start, Spot end)
        {
            this.player = player;
            this.start = start;
            this.end = end;
            this.pieceMoved = start.Piece;
        }

        public bool CastlingMove
        {
            get { return castlingMove; }
            set { castlingMove = value; }
        }
    }
}
