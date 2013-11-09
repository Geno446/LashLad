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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Timer mainTimer = new Timer();
            mainTimer.Interval = 30;
            mainTimer.Tick += mainTimer_Tick;
            mainTimer.Start();
        }

        void mainTimer_Tick(object sender, EventArgs e)
        {
            MainThread();
        }

        private void MainThread()
        {

        }

        private void Draw()
        {

        }
    }
}
