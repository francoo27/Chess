//This file is part of Chess.
//Chess is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//Chess is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with Chess. If not, see <https://www.gnu.org/licenses/>.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public class Board
    {
        Spot[,] boxes = new Spot[8, 8];

        public Board()
        {
            resetBoard();
        }

        public Spot getBox(int x, int y)
        {

            if (x < 0 || x > 7 || y < 0 || y > 7)
            {
                throw new Exception("Index out of bound");
            }

            return boxes[x, y];
        }

        public void resetBoard()
        {
            // WHITE PIECES
            boxes[0, 0] = new Spot(0, 0, new Rook(true));
            boxes[1, 0] = new Spot(1, 0, new Knight(true));
            boxes[2, 0] = new Spot(2, 0, new Bishop(true));
            boxes[3, 0] = new Spot(3, 0, new King(true));
            boxes[4, 0] = new Spot(4, 0, new Queen(true));
            boxes[5, 0] = new Spot(5, 0, new Bishop(true));
            boxes[6, 0] = new Spot(6, 0, new Knight(true));
            boxes[7, 0] = new Spot(7, 0, new Rook(true));
            boxes[0, 1] = new Spot(0, 1, new Pawn(true));
            boxes[1, 1] = new Spot(1, 1, new Pawn(true));
            boxes[2, 1] = new Spot(2, 1, new Pawn(true));
            boxes[3, 1] = new Spot(3, 1, new Pawn(true));
            boxes[4, 1] = new Spot(4, 1, new Pawn(true));
            boxes[5, 1] = new Spot(5, 1, new Pawn(true));
            boxes[6, 1] = new Spot(6, 1, new Pawn(true));
            boxes[7, 1] = new Spot(7, 1, new Pawn(true));
            //...

            // BLACK PIECES
            boxes[0, 7] = new Spot(0, 7, new Rook(false));
            boxes[1, 7] = new Spot(1, 7, new Knight(false));
            boxes[2, 7] = new Spot(2, 7, new Bishop(false));
            boxes[3, 7] = new Spot(3, 7, new King(false));
            boxes[4, 7] = new Spot(4, 7, new Queen(false));
            boxes[5, 7] = new Spot(5, 7, new Bishop(false));
            boxes[6, 7] = new Spot(6, 7, new Knight(false));
            boxes[7, 7] = new Spot(7, 7, new Rook(false));
            boxes[0, 6] = new Spot(0, 6, new Pawn(false));
            boxes[1, 6] = new Spot(1, 6, new Pawn(false));
            boxes[2, 6] = new Spot(2, 6, new Pawn(false));
            boxes[3, 6] = new Spot(3, 6, new Pawn(false));
            boxes[4, 6] = new Spot(4, 6, new Pawn(false));
            boxes[5, 6] = new Spot(5, 6, new Pawn(false));
            boxes[6, 6] = new Spot(6, 6, new Pawn(false));
            boxes[7, 6] = new Spot(7, 6, new Pawn(false));

            // initialize remaining boxes without any piece
            for (int i = 0; i < 8; i++)
            {
                for (int j = 2; j < 6; j++)
                {
                    boxes[i, j] = new Spot(i, j, null);
                }
            }
        }

        public string PrintBoard()
        {
            string s = "";
            for (int i = 0; i < 8; i++)
            {
                s += $"{i}|";
                for (int j = 0; j < 8; j++)
                {
                    s += $" {gs(boxes[j, i])} |";

                }
                s += "\n --------------------------------- \n";

            }
            s += "   0   1   2   3   4   5   6   7";
            return s;
        }

        private string gs(Spot s)
        {
            return s.Piece is null ? " " : s.Piece.Icon;
        }
    }
}
