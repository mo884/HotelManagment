using HotelManagment.BLL.Feature.CreditCard.Command.Interface;
using HotelManagment.BLL.Feature.CreditCard.Command.Reposoratory;
using HotelManagment.BLL.Feature.CreditCard.ModelVM;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagment.PLL
{
    public partial class CreditCard : Form
    {
        IAddCridetCardRep addCridetCardRep;
        public CreditCard()
        {
            InitializeComponent();
            addCridetCardRep = new AddCridetCardRep();
        }



        private void CreditCard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckFoodMenue.GuestID != 0)
            {
                AddCridetVM addCridetVM = new AddCridetVM()
                {
                    card_cvc = textBox1.Text,
                    card_type = textBox2.Text.ToString(),
                    card_number = comboBox2.SelectedValue.ToString(),
                    card_exp = comboBox3.SelectedValue.ToString(),
                    GuestID = CheckFoodMenue.GuestID,
                    payment_type = comboBox5.SelectedValue.ToString()
                };

                addCridetCardRep.Add(addCridetVM);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text=="MM")
                comboBox3.Text="";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text=="                9999 - 9999 - 9999 - 9999")
                textBox1.Text="";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text=="YY")
                comboBox2.Text="";

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text=="Type")
                comboBox5.Text="";

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreditCard_Load_1(object sender, EventArgs e)
        {
            List<Month> months = new List<Month>();
            months.Add(new Month(1));
            months.Add(new Month(2));
            months.Add(new Month(3));
            months.Add(new Month(4));
            months.Add(new Month(5));
            months.Add(new Month(6));
            months.Add(new Month(7));
            months.Add(new Month(8));
            months.Add(new Month(9));
            months.Add(new Month(10));
            months.Add(new Month(11));
            months.Add(new Month(12));
            comboBox3.DataSource = months;
            comboBox3.DisplayMember = "Number";
            comboBox3.ValueMember = "Number";

            int currentYear = DateTime.Now.Year % 100;

            int numberOfYears = 10;

            List<string> years = new List<string>();
            for (int i = 0; i < numberOfYears; i++)
            {
                years.Add((currentYear + i).ToString("00"));
            }

            comboBox2.DataSource = years;

            comboBox2.SelectedIndex = 0;
            List<string> creditCardTypes = new List<string>()
               {
                "Visa",
                "MasterCard",
                "American Express",
       
                 };

            comboBox5.DataSource = creditCardTypes;

            comboBox5.SelectedIndex = 0;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text=="CVC")
                textBox2.Text="";
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text=="       9999 - 9999 - 9999 - 9999")
                textBox1.Text="";
        }
    }
}
