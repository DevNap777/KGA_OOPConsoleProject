using KGA_OOPConsoleProject.GameObjects;
using KGA_OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class TopFloorScene : BaseFloorScene
    {
        public TopFloorScene()
        {
            name = "TopFloor";

            mapData = new string[]
           {
                "▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩", // y = 6, x = 8
                "▩          ▩     ▩",
                "▩▩▩▩▩▩     ▩     ▩",
                "▩    ▩     ▩     ▩",
                "▩                ▩",
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
            objects.Add(new Door("SecondFloor", 'D', new Vector(4, 16)));
            objects.Add(new Key(new Vector(4, 1)));

            GameMain.Player.position = new Vector(1, 1);
        }

        public override void Enter()
        {
            if (GameMain.beforeScene == "SecondFloor")
            {
                GameMain.Player.position = new Vector(4, 16);
            }
            GameMain.Player.map = map;
        }
    }
}
