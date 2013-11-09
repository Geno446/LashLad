using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace LashLad.View.Sprites
{
    class Sprite : ISprite
    {
        public Bitmap GetSprite(Model.IEntity Entity)
        {
            //This variable exists only until we start using file sprites.
            int ii = 40;
            // as does this one
            Bitmap bm = new Bitmap(ii, ii);
            // also this
            // Default case
            Color col = Color.Black;

            if (Entity is Model.Human)
            {
                col = Color.Fuchsia;
                return bm;
            }

            for (int x = 0; x < ii; x++)
            {
                for (int y = 0; y < ii; y++)
                {
                    bm.SetPixel(x, y, col);
                }
            }
            return bm;
        }
    }
}
