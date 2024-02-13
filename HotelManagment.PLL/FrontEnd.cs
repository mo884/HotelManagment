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


                if (flowLayoutPanel1.Width == flowLayoutPanel1.MinimumSize.Width)
                {
                    flowLayoutPanel1.Width +=200;
                    sideBarIsOpen = true;
                    timer1.Stop();
                }
                else
                {

                    if (flowLayoutPanel1.Width==flowLayoutPanel1.MaximumSize.Width)
                    {
                        flowLayoutPanel1.Width -=200;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Click(object sender, EventArgs e)
        {
            panel19.Location = new Point(220, 0);
            panel19.Visible =true;
            Search.Location = new Point(-1800, 125);
            Search.Visible =false;
            Grid.Location =new Point(-1900, 125);
            Grid.Visible =false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search.Location = new Point(275, 128);
            panel19.Location = new Point(-1826, 0);
            Search.Visible =true;
            Grid.Location =new Point(-1900, 125);

            Grid.Visible =false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grid.Location = new Point(230, 10);
            panel19.Location = new Point(-1826, 0);
            Search.Location = new Point(-1800, 125);
            Grid.Visible =true;

        }
    }
}
