using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    /// <summary>
    /// 게임 내에서 상호작용할 수 있는 Object 생성
    /// 맵 내에 있어야 하므로 player와 마찬가지로 구조체를 가지고 있음.
    /// </summary>
    public abstract class Object : IInteractable
    {
        // Object 정보들
        // Object 색 지정, 변수 선언 및 초기화
        public ConsoleColor consoleColor;
        public char doorObject;

        // Object의 위치
        public Vector position;


        // Object가 표현될 방법
        public void PrintObject()
        {
            // Vector 구조체를 받아서 위치 지정을 위한
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = consoleColor;
            // doorObject 표현
            Console.Write(doorObject);
            Console.ResetColor();
        }

        // Utill과 비슷한 느낌으로 구현
        // 생성자에 내용을 포함하여 구현
        public Object(ConsoleColor consoleColor, char doorObject, Vector position)
        {
            this.consoleColor = consoleColor;
            this.doorObject = doorObject;
            this.position = position;
        }

        public abstract void Interact(Player player);
    }
}
