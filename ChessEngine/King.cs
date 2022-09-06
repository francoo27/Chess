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
    public class King : Piece
    {
        public King(bool white) : base(white, typeof(King).Name) { }

        public override bool CanMove(Board board, Spot start, Spot end)
        {
            // CHECK IF THE PIECE IS BEING MOVED TO A SAME COLOR PIECE
            bool res = true;
            if (end.Piece is not null && end.Piece.White == White)
            {
                res = false;
            }

            int x = Math.Abs(start.X - end.X);
            int y = Math.Abs(start.Y - end.Y);
            if (x + y == 1)
            {
                // check if this move will not result in the king
                // being attacked if so return true
                res = true;
            }
            return res;
        }

    }
}

