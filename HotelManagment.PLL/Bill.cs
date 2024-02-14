using HotelManagment.BLL.Feature.Finalize_bill.ModelVM;
using HotelManagment.BLL.Feature.Finalize_bill.Queries.Interface;
using HotelManagment.BLL.Feature.Finalize_bill.Queries.Reposoratory;
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
    public partial class Bill : Form
    {
        IFinalizebillRep finalizebillRep;
        public Bill()
        {
            InitializeComponent();
            finalizebillRep = new FinalizebillRep();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            FinalizeBillVM finalizeBillVM = finalizebillRep.GetFinalizebill(CheckFoodMenue.RoomID, CheckFoodMenue.GuestID, CheckFoodMenue.ReserveFoodID);
            label5.Text = finalizeBillVM.RoomBill.ToString();
            label6.Text = finalizeBillVM.FoodBill.ToString();
            label7.Text = finalizeBillVM.Total.ToString();
            textBox2.Text = finalizeBillVM.GuestVM.CreditCared.card_cvc.ToString();
            textBox1.Text = finalizeBillVM.GuestVM.CreditCared.card_number.ToString();
            textBox3.Text = finalizeBillVM.GuestVM.CreditCared.card_type.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
