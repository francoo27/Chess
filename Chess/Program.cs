//This file is part of Chess.
//Chess is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//Chess is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with Chess. If not, see <https://www.gnu.org/licenses/>.
using ChessEngine;
namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game GAME = new Game();
            HumanPlayer playerONE = new HumanPlayer("A",true);
            HumanPlayer playerTWO = new HumanPlayer("B",false);
            GAME.Initialize(playerONE, playerTWO);
            Console.WriteLine(GAME.PrintBoard());
            while (!GAME.IsEnd())
            {
                Console.WriteLine(GAME.CurrentTurn.Name.ToString());
                Console.Write("Inicio X:");
                int startX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inicio Y:");
                int startY = Convert.ToInt32(Console.ReadLine());
                Console.Write("FIN X:");
                int endX = Convert.ToInt32(Console.ReadLine());
                Console.Write("FIN Y:");
                int endY = Convert.ToInt32(Console.ReadLine());
                GAME.PlayerMove(GAME.CurrentTurn,startX,startY,endX,endY);
                Console.Clear();
                Console.WriteLine(GAME.PrintBoard());
            }
        }
    }
}