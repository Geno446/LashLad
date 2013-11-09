using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LashLad.View
{
    class DisplayObject : IDisplayObject
    {
        // Todo implement sprite caching.
        public DisplayObject(int x, int y, Model.DisplayType displayType)
        {
            X = x;
            Y = y;

            // Temp
            int xy = 40;
            Bitmap bm = new Bitmap(xy, xy);
            Color col = Color.Black;

            //

            switch (displayType)
            {
                case Model.DisplayType.Human:
                    col = Color.Fuchsia;
                    break;
                default:
                    break;
            }

            // Temp
            for (int i = 0; i < xy; i++)
            {
                for (int j = 0; j < xy; j++)
                {
                    bm.SetPixel(i, j, col);
                }
            }
            //
            Sprite = bm;

        }
        public int X { protected set; get; }

        public int Y { protected set; get; }

        public Bitmap Sprite { protected set; get; }
    }
}
