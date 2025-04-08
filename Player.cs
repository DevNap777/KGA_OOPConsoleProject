﻿using System;
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

        // Player에 map을 넣어서 구동될 수 있게 함.
        public bool[,] map;

        public void PrintPlayer()
        {
            Console.SetCursorPosition(position.x, position.y);
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
            Vector movePosition = position;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    movePosition.y--;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    movePosition.y++;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    movePosition.x--;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    movePosition.x++;
                    break;
            }

            if (map[movePosition.y, movePosition.x] == true)
            {
                position = movePosition;
            }
        }
    }
}
