using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LashLad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(keyPress);
        }

        private void keyPress(object sender, KeyEventArgs e)
        {
            new KeyPressHandler(e.KeyCode);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
