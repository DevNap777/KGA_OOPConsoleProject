using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    /// <summary>
    /// player와 상호 작용할 수 있도록 Interface 생성
    /// </summary>
    public interface IInteractable
    {
        public void Interact(Player player);
    }
}
