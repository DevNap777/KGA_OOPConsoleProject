using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    /// <summary>
    /// player 이동 위치를 담기 위한 구조체
    /// </summary>
    public struct Vector
    {
        public int y;
        public int x;

        public Vector(int y, int x)
        {
            this.y = y;
            this.x = x;
        }
    }
}
