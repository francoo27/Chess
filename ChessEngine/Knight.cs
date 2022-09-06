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

    public class Knight : Piece
    {
        public Knight(bool white) : base(white, typeof(Knight).Name)
        {
        }

        public override bool CanMove(Board board, Spot start,
                                                Spot end)
        {
            if (end.Piece is not null && end.Piece.White == White)
            {
                return false;
            }

            int x = Math.Abs(start.X - end.X);
            int y = Math.Abs(start.Y - end.Y);
            return x * y == 2;
        }
    }
}
