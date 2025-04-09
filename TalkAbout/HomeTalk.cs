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

            Console.WriteLine("??? : 으... 머리야...");
            Utill.Print("??? : 뭐지.. 여긴 어디지...?", ConsoleColor.White, 1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                     Enter...");
            
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("덜컥 덜컥..");
            Console.WriteLine();
            Utill.Print("??? : 어....", ConsoleColor.White, 1000);
            Console.WriteLine();
        }
    }
}
