using KGA_OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.GameObjects
{
    /// <summary>
    /// 이동을 위한 Door Object생성
    /// </summary>
    public class Door : Object
    {
        
        // Object와 상호작용을 하게 되면 이동을 해야 하므로
        private string sceneName;
        public Door(string scnenName, char symbol, Vector position) : base(ConsoleColor.Yellow, symbol, position, false)
        {
            this.sceneName = scnenName;
        }

        public override void Interact(Player player)
        {
            // TODO : 여기서 key를 받고
            // TODO : 그 다음에 씬 전환
            GameMain.ChangeScene(sceneName);
        }
    }
}
