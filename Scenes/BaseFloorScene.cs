﻿using KGA_OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class BaseFloorScene : Scene
    {
        /// <summary>
        /// Player가 이동할 수 있는 맵 생성
        /// </summary>
        
        // string 배열로 mapData를 받고 
        // bool 2차원 배열로 맵 생성
        protected string[] mapData;
        protected bool[,] map;

        // Objects를 가지고 있을 수 있도록 List배열로 생성
        protected List<Object> objects; 

        public override void Render()
        {
            // 맵 출력
            PrintMap();
            // Object 출력
            foreach (Object loop in objects)
            {
                loop.PrintObject();
            }
            // player 출력
            GameMain.Player.PrintPlayer();

            Console.SetCursorPosition(0, map.GetLength(0) + 6);
            GameMain.Player.inventory.PrintAll();
        }
        public override void Choice()
        {

        }
        public override void Update()
        {
            GameMain.Player.MovePlayer(input);
            GameMain.Player.OpneInventory(input);
        }

        public override void Result()
        {
            // doorObject와 player가 겹쳐 상호작용하면
            // object 전체를 순회하면서
            foreach (Object loop in objects)
            {
                // 만약 player와 object의 위치가 같다면
                if (GameMain.Player.position.x == loop.position.x && GameMain.Player.position.y == loop.position.y)
                {
                    // 상호작용 할 수 있도록
                    loop.Interact(GameMain.Player);

                    // 1회용 아이템 획득 후 지우기
                    if (loop.useOnlyOne == true)
                    {
                        objects.Remove(loop);
                    }
                    break;
                }
            }
        }

        private void PrintMap()
        {
            Console.CursorVisible = false;

            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    // 2차원 배열 y, x가 맞다면
                    if (map[y, x] == true)
                    {
                        // 이동 가능
                        Console.Write(' ');
                    }
                    // 아니라면
                    else
                    {
                        // 이동 불가
                        Console.Write('▩');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
