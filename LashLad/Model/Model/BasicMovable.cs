using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LashLad.Model
{
    class BasicMovable : IMovable
    {

        public BasicMovable(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool MoveTo(int x, int y, int speed = 1)
        {
            // todo not teleport
            TeleportTo(x, y);
            // todo collision
            return true;
        }

        public bool TeleportTo(int x, int y)
        {
            this.X = x;
            this.Y = y;
            return true;
        }


        public int X { protected set; get; }

        public int Y { protected set; get; }

        DisplayType IEntity.DisplayType { get { return DisplayType.Human; } }
    }
}
