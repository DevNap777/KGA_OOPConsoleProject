using KGA_OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Items
{
    public class Key : Item
    {
        public Key(Vector position) : base(ConsoleColor.Green, 'K', position)
        {

            name = "열쇠";
            description = "문을 열어 나갈 수 있다.";
        }

        public override void Use()
        {
            // TODO : 여기서 키를 사용하고
            
        }
    }
}
