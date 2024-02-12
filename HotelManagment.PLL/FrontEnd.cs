using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment.PLL
{
    public partial class FrontEnd : Form
    {
        bool sideBarIsOpen = true;
        public FrontEnd()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sideBarIsOpen)
            {
                flowLayoutPanel1.Width -=190;

                if (flowLayoutPanel1.Width == flowLayoutPanel1.MinimumSize.Width)
                {
                    sideBarIsOpen = false;
                    timer1.Stop();
                }
                else
                {
                    flowLayoutPanel1.Width +=190;
                    if (flowLayoutPanel1.Width==flowLayoutPanel1.MaximumSize.Width)
                    {
                        sideBarIsOpen = true;
                        timer1.Stop();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FrontEnd_Load(object sender, EventArgs e)
        {

        }
    }
}
