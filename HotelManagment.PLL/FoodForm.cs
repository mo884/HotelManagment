
using HotelManagment.BLL.Feature.HousKeepingRep.Command.Interface;
using HotelManagment.BLL.Feature.HousKeepingRep.Command.Reposoratory;
using HotelManagment.BLL.Feature.HousKeepingRep.Queries.Interface;
using HotelManagment.BLL.Feature.HousKeepingRep.Queries.Reposoratory;
using HotelManagment.BLL.Feature.MenuInfo.Command.Interface;
using HotelManagment.BLL.Feature.MenuInfo.Command.Reposoratoey;
using HotelManagment.BLL.Feature.MenuInfo.ModelVM;
using HotelManagment.BLL.Feature.MenuInfo.Queries.Interface;
using HotelManagment.BLL.Feature.MenuInfo.Queries.Reposoratoey;
using HotelManagment.BLL.Helpers;
using HotelManagment.DAL.Entities.Reservations.Foods.Enum;
using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelManagment.PLL
{
    public partial class FoodForm : Form
    {
        IGetMenuInfoRepoBYID getMenuInfoRepoBYID;
        IAddMenuInfoRep addMenuInfoRep;
        IEditMenuInfoRep editMenuInfoRep;
        IAddHousKeepingRep AddHousKeepingRep;
        IGetKeepHousingByID GetGetKeepHousingByID;
        IEditHousKepingRep editHousKepingRep;
        public FoodForm()
        {
            InitializeComponent();
           
            AddHousKeepingRep = new AddHousKeepingRep();
            GetGetKeepHousingByID = new GetKeepHousingByID();
            getMenuInfoRepoBYID = new GetMenuInfoRepoBYID();
            addMenuInfoRep = new AddMenuInfoRep();
            editMenuInfoRep = new EditMenuInfoRep();
            editHousKepingRep = new EditHousKepingRep();
        }

        MenuInfoVM menuInfoVM;
        Housekeeping housekeeping;

        private void FoodForm_Load(object sender, EventArgs e)
        {
            if (CheckFoodMenue.ReserveFoodID == 0)
            {
                textBox1.Text ="";
                textBox2.Text="";
                textBox3.Text="";
                checkBox1.Checked=false;
                checkBox2.Checked=false;
                checkBox3.Checked=false;
                checkBox4.Checked=false;
                checkBox5.Checked=false;
                checkBox6.Checked=false;
            }
            else
            {
                menuInfoVM = getMenuInfoRepoBYID.Get(CheckFoodMenue.ReserveFoodID);
                housekeeping = GetGetKeepHousingByID.GetHousekeepingByID(CheckFoodMenue.KeepHousingID);
                if (menuInfoVM.Isbreak_fast)
                {
                    checkBox1.Checked = true;
                    textBox1.Text = menuInfoVM.Countbreak_fast.ToString();
                }

                if (menuInfoVM.Islunch)
                {
                    checkBox2.Checked = true;
                    textBox2.Text = menuInfoVM.Countlunch.ToString();
                }
                else
                {
                    checkBox2.Checked=false;
                    textBox2.Visible=false;

                }

                if (menuInfoVM.Isdinner)
                {
                    checkBox3.Checked = true;
                    textBox3.Text = menuInfoVM.Countdinner.ToString();
                }
                else
                {
                    checkBox3.Checked=false;
                    textBox3.Visible=false;

                }

                checkBox4.Checked=housekeeping.s_surprise;
                checkBox5.Checked=housekeeping.towel;
                checkBox6.Checked=housekeeping.cleaning;




            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (CheckFoodMenue.ReserveFoodID == 0)
            {
                MenuInfoVM menuInfoVM = new MenuInfoVM()
                {
                    Isbreak_fast = checkBox2.Checked,
                    Isdinner = checkBox3.Checked,
                    Islunch = checkBox1.Checked,
                    Countdinner = int.Parse(textBox3.Text),
                    Countlunch = int.Parse(textBox2.Text),
                    Countbreak_fast = int.Parse(textBox1.Text),
                    Pricebreak_fast = 7,
                    Pricedinner =15,
                    Pricelunch=15,
                };
                addMenuInfoRep.Add(menuInfoVM);

                AddHousKeepingRep.Add(new() { cleaning = checkBox6.Checked,towel=checkBox5.Checked,s_surprise=checkBox4.Checked });
                AddHousKeepingRep.Add(new() { s_surprise= checkBox4.Checked, towel= checkBox5.Checked, cleaning= checkBox5.Checked });



            }
            else
            {
                if (checkBox1.Checked==true)
                {
                    menuInfoVM.Isbreak_fast =true;
                    menuInfoVM.Countbreak_fast = decimal.Parse(textBox1.Text);
                }
                else
                {
                    menuInfoVM.Isbreak_fast =false;
                    menuInfoVM.Countbreak_fast = 0;
                }
                if (checkBox2.Checked==true)
                {
                    menuInfoVM.Islunch =true;
                    menuInfoVM.Countlunch = decimal.Parse(textBox2.Text);

                }
                else
                {
                    menuInfoVM.Islunch =false;
                    menuInfoVM.Countlunch = 0;
                }

                if (checkBox3.Checked==true)
                {
                    menuInfoVM.Isdinner =true;
                    menuInfoVM.Countdinner = decimal.Parse(textBox3.Text);

                }
                else
                {

                    menuInfoVM.Isdinner =false;
                    menuInfoVM.Countdinner = 0;
                }
                editMenuInfoRep.Edit(menuInfoVM);

                housekeeping.s_surprise=checkBox4.Checked;
                housekeeping.towel=checkBox5.Checked;
                housekeeping.cleaning=checkBox6.Checked;
                editHousKepingRep.Edit(housekeeping);
                this.Close();
            }
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
