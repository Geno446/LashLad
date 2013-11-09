using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LashLad
{
    class KeyPressHandler
    {
        private KeyPressHandler(){ }

        public KeyPressHandler(Keys keys)
        {
            switch (keys)
            {
                case Keys.W:
                    //call player.move
                    break;
                case Keys.A:
                    break;
                case Keys.S:
                    break;
                case Keys.D:
                    break;
            }
        }
    }
}
