using KGA_OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Inventory
    {
        // 아이템 보관 List 생성
        private List<Item> items;

        // 인벤토리 오픈 기능
        private Stack<string> stack;

        public Inventory()
        {
            items = new List<Item>();
            stack = new Stack<string>();
        }

        // 아이템 추가
        public void Add(Item item)
        {
            items.Add(item);
        }

        // 아이템 삭제
        public void Remove(Item item)
        {
            items.Remove(item);
        }

        // 아이템 삭제
        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }

        // 아이템 사용
        public void UseAt(int index)
        {
            items[index].Use();
        }

        // 인벤토리 열기
        public void Open()
        {
            stack.Push("MainMenu");

            while (stack.Count > 0)
            {
                Console.Clear();

                switch (stack.Peek())
                {
                    case "MainMenu":
                        MainMenu();
                        break;
                    case "UseMenu":
                        UseMenu();
                        break;
                    case "DropMenu":
                        DropMenu();
                        break;
                }
            }
        }

        public void MainMenu()
        {
            PrintAll();

            Console.WriteLine("1. 아이템 사용");
            Console.WriteLine("2. 아이템 버림");
            Console.WriteLine("3. 나가기");

            ConsoleKey input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.D1:
                    stack.Push("UseMenu");
                    break;
                case ConsoleKey.D2:
                    stack.Push("DropMenu");
                    break;
                case ConsoleKey.D3:
                    stack.Pop();
                    break;
            }
        }

        public void UseMenu()
        {
            PrintAll();

            Console.WriteLine("1. 사용할 아이템을 선택하세요");
            Console.WriteLine("2. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.D2:
                    stack.Pop();
                    break;
            }
        }

        public void DropMenu()
        {
            PrintAll();

            Console.WriteLine("1. 버릴 아이템을 선택하세요");
            Console.WriteLine("2. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.D2:
                    stack.Pop();
                    break;
            }
        }


        public void PrintAll()
        {
            Console.WriteLine("##### 보유 아이템 목록 #####");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i+1}, {items[i].name}");
            }
            Console.WriteLine("############################");
        }
    }
}
