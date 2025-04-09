using KGA_OOPConsoleProject.TalkAbout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class HomeScene : Scene
    {
        HomeTalk HomeTalk = new();

        public override void Render()
        {
            HomeTalk.TalkHome();
        }

        public override void Choice()
        {
            Console.WriteLine("1. 문을 열어본다.");
            Console.WriteLine("2. 그냥 있는다.");
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("문이 닫혀있다. 나갈 방법을 찾아보자.");
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("평생... 잠이나 쳐 자세요...");
                    Console.WriteLine("BAD ENDING");
                    Console.ResetColor();
                    return;

            }
        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    GameMain.ChangeScene("TopFloor");
                    break;
            }
        }
    }
}
