using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.GameObjects
{
    public abstract class Item : Object
    {
        public string name;
        public string description;
        public Item(ConsoleColor consoleColor, char symbol, Vector position) : base(ConsoleColor.Green, symbol, position, true)
        {

        }

        public override void Interact(Player player)
        {
            // 아이템 획득
            player.inventory.Add(this);
        }

        public abstract void Use();
    }
}
