//This file is part of Chess.
//Chess is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//Chess is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with Chess. If not, see <https://www.gnu.org/licenses/>.
using System;
using System.Xml.Linq;

namespace ChessEngine
{
    public abstract class Piece
    {

        private bool killed = false;
        private bool white = false;
        internal string name;
        public string Icon => name.Substring(0,1);
        public string Name
        {
            get { return name; }
            internal set { name = value; }
        }

        public Piece(bool white, string name)
        {
            White = white;
            Name = name;    
        }

        public bool White
        {
            get { return white; }
            set { white = value; }
        }

        public bool Killed
        {
            get { return killed; }
            set { killed = value; }
        }

        public abstract bool CanMove(Board board, Spot start, Spot end);
    }
}