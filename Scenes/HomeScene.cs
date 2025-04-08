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
            Console.WriteLine("1. 문을 열어준다.");
            Console.WriteLine("2. 더 잔다.");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("누구지...? 밖으로 나가보자");
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

        public override void Wait()
        {
            Console.WriteLine("                        Enter...");
            Console.ReadLine();
        }
        public override void Next()
        {
            
        }
    }
}
