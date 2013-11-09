using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LashLad.View.Sprites
{
    interface ISprite
    {
        Bitmap GetSprite(Model.IEntity Entity);
    }
}