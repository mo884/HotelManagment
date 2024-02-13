using HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Interface;
using HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Reposoratory;
using HotelManagment.BLL.Feature.DailyDiningBundleRep.ModelVM;
using HotelManagment.BLL.Helpers;
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
    public partial class FoodForm : Form
    {
        IAddDailyDiningBundleRep AddDailyDiningBundleRep;
        public FoodForm()
        {
            InitializeComponent();
            AddDailyDiningBundleRep = new AddDailyDiningBundleRep();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;

        }
        List<DailyDiningBundleVM> dailyDiningBundleVM = new List<DailyDiningBundleVM>();
        private void FoodForm_Load(object sender, EventArgs e)
        {
            if (CheckFoodMenue.GuestID == 0&&CheckFoodMenue.RoomID==0)
            {
                textBox1.Text ="";
                textBox2.Text="";
                textBox3.Text="";
                checkBox1.Checked=false;
                checkBox2.Checked=false;
                checkBox3.Checked=false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
                dailyDiningBundleVM.Add(new DailyDiningBundleVM() { Type = DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.break_fast, Price=7,Count=int.Parse(textBox1.Text) });
            if (checkBox2.Checked==true)
                dailyDiningBundleVM.Add(new DailyDiningBundleVM() { Type = DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.lunch, Price=15, Count=int.Parse(textBox2.Text) });
            if (checkBox3.Checked==true)
                dailyDiningBundleVM.Add(new DailyDiningBundleVM() { Type = DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.dinner, Price=15, Count=int.Parse(textBox3.Text) });

            AddDailyDiningBundleRep.Add(dailyDiningBundleVM);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                textBox1.Visible =true;

            }else
            {
                textBox1.Visible =false;

            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                textBox2.Visible =true;

            }
            else
            {
                textBox2.Visible =false;

            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked==true)
            {
                textBox3.Visible =true;

            }
            else
            {
                textBox3.Visible =false;

            }

        }
    }
}
