//This file is part of Chess.
//Chess is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//Chess is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with Chess. If not, see <https://www.gnu.org/licenses/>.
namespace ChessEngine
{
    public abstract class Player
    {
        private string? name;
        private bool whiteSide;
        private bool humanPlayer;

        public string Name
        {
            get { return name!; }
            internal set { name = value; }
        }

        public bool HumanPlayer
        {
            get { return humanPlayer; }
            internal set { humanPlayer = value; }
        }

        public bool WhiteSide
        {
            get { return whiteSide; }
            internal set { whiteSide = value; }
        }
    }

    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, bool whiteSide)
        {
            Name = name;
            WhiteSide = whiteSide;
            HumanPlayer = true;
        }
    }
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(bool whiteSide)
        {
            Name = "COMPUTER";
            WhiteSide = whiteSide;
            HumanPlayer = false;
        }
    }
}
