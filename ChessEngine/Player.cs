﻿//This file is part of Chess.
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
    public abstract class Player
    {
        public bool whiteSide;
        public bool humanPlayer;
        private string name;

        public string Name
        {
            get { return name; }
            internal set { name = value; }
        }

        public bool isWhiteSide() => whiteSide;
        public bool isHumanPlayer() => humanPlayer;
    }

    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, bool whiteSide)
        {
            this.Name = name;
            this.whiteSide = whiteSide;
            humanPlayer = true;
        }
    }
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(bool whiteSide)
        {
            this.whiteSide = whiteSide;
            humanPlayer = false;
        }
    }
}
