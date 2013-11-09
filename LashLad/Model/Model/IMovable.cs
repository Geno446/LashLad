using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LashLad.Model
{
    interface IMovable : IEntity 
    {
        bool MoveTo(int x, int y, int speed =1);
        bool TeleportTo(int x, int y);
    }
}
