using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LashLad.View
{
    interface IDisplayObject
    {
        int X { get; }
        int Y { get; }
        Bitmap Sprite { get; }
    }
}