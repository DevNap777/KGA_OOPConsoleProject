using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.TalkAbout
{
    public class HomeTalk
    {
        public void TalkHome()
        {
            Utill.Print("19XX년 XX월 XX일...", ConsoleColor.DarkGray, 1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("          Enter...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("??? : 으... 피곤해...");
            Utill.Print("??? : 오늘이 출발하는 날이지... 지금 몇시야..?", ConsoleColor.White, 1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                     Enter...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("??? : 야 \"나아암사아치이인!\" 빨리 안나올래!!??");
            Console.WriteLine();
        }
    }
}
