using KGA_OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class FirstFloorScene : BaseFloorScene
    {
        public FirstFloorScene()
        {
            name = "FirstFloor";

            mapData = new string[]
           {
                "▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩", // y = 6, x = 18
                "▩ ▩   ▩   ▩   ▩  ▩",
                "▩ ▩ ▩ ▩ ▩ ▩ ▩ ▩  ▩",
                "▩ ▩ ▩ ▩ ▩ ▩ ▩ ▩  ▩",
                "▩   ▩   ▩   ▩    ▩",
                "▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩",
           };

            map = new bool[6, 18];

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
            objects = new List<Object>();
            objects.Add(new Door("FirstFloor", 'D', new Vector(1, 16)));
        }

        public override void Enter()
        {
            if (GameMain.beforeScene == "SecondFloor")
            {
                GameMain.Player.position = new Vector(1, 1);
            }
            GameMain.Player.map = map;
        }

        public override void Exit()
        {
            foreach (Object loop in objects)
            {
                // 만약 player와 object의 위치가 같다면
                if (GameMain.Player.position.x == loop.position.x && 
                    GameMain.Player.position.y == loop.position.y)
                {
                    // 상호작용 할 수 있도록
                    Console.Clear();
                    GameMain.GameOver("아오.. 머리야...");
                }
            }
        }
    }
}
