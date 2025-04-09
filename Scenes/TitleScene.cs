using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("/////..././/././/////.//...///...////");
            Console.WriteLine("//             ㅋㅋ ㅋ             ..");
            Console.WriteLine("..           ㅋㅋㅋㅋㅋㅋ          //");
            Console.WriteLine("/..//..././/././/..///.//...///...///");
            Console.WriteLine();
        }
        public override void Choice()
        {
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Load Game[미구현]");
            Console.WriteLine("3. Exit");
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    GameMain.ChangeScene("Home");
                    break;
            }
        }
    }
}
