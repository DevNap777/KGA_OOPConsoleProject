using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Player
    {
        // Player의 위치를 나타내기 위해 Vector 구조체 사용
        public Vector position;

        public void PrintPlayer()
        {
            Console.SetCursorPosition(position.y, position.x);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("●");
            Console.ResetColor();
        }

        /// <summary>
        /// input을 통해 player 이동 구현
        /// </summary>
        /// <param name="input"></param>
        public void MovePlayer(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    position.y--;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    position.y++;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    position.x--;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    position.x++;
                    break;
            }
        }
    }
}
