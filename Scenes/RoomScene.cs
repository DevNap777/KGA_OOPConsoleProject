using KGA_OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class RoomScene : Scene
    {
        /// <summary>
        /// Player가 이동할 수 있는 맵 생성
        /// </summary>
        
        // string 배열로 mapData를 받고 
        // bool 2차원 배열로 맵 생성
        private string[] mapData;
        private bool[,] map;

        // Objects를 가지고 있을 수 있도록 List배열로 생성
        private List<Object> objects = new List<Object>(); 

        public RoomScene()
        {
            mapData = new string[]
            {
                "▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩", // 20 / 10
                "▩                  ▩",
                "▩▩▩▩▩▩▩▩     ▩     ▩",
                "▩      ▩     ▩     ▩",
                "▩      ▩     ▩     ▩",
                "▩▩▩  ▩▩▩     ▩     ▩",
                "▩            ▩▩▩▩▩▩▩",
                "▩▩▩  ▩▩▩           ▩",
                "▩      ▩           ▩",
                "▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩",
            };

            map = new bool[10, 20];

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    // 2차원 배열에서 ? 조건 연산자 사용.
                    // ? 왼쪽이 맞다면 false(이동불가), 아니라면 true(이동 가능)
                    map[y, x] = mapData[y][x] == '▩' ? false : true;
                }
            }

            // Object 위치 설정
            objects.Add(new Door("Home", 'D', new Vector(8, 18)));

            // RoomScene에서 player 위치 설정
            GameMain.Player.position = new Vector(8, 4);
            GameMain.Player.map = map;
        }

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
        }
        public override void Choice()
        {

        }
        public override void Update()
        {
            GameMain.Player.MovePlayer(input);
        }

        public override void Result()
        {

        }

        public override void Wait()
        {

        }
        public override void Next()
        {

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
