using HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Interface;
using HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Reposoratory;
using HotelManagment.BLL.Feature.DailyDiningBundleRep.ModelVM;
using HotelManagment.BLL.Feature.DailyDiningBundleRep.Queries.Interface;
using HotelManagment.BLL.Feature.DailyDiningBundleRep.Queries.Reposoratory;
using HotelManagment.BLL.Feature.HousKeepingRep.Command.Interface;
using HotelManagment.BLL.Feature.HousKeepingRep.Command.Reposoratory;
using HotelManagment.BLL.Feature.HousKeepingRep.Queries.Interface;
using HotelManagment.BLL.Feature.HousKeepingRep.Queries.Reposoratory;
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
        IAddDailyDiningBundleRep AddDailyDiningBundleRep;
        IGetDialyByUser getDialyByUser;
        IDailyDiningBundleGetByIdRep DailyDiningBundleGetByIdRep;
        IAddHousKeepingRep AddHousKeepingRep;
        IGetKeepHousingByID GetGetKeepHousingByID;
        IRemoveDailyDiningBundleRep RemoveDailyDiningBundleGetByIdRep;
        IEditDailyDiningBundleRep EditDailyDiningBundleRep;
        IAddMailByIDMenue AddMailByIDMenue;
        public FoodForm()
        {
            InitializeComponent();
            AddDailyDiningBundleRep = new AddDailyDiningBundleRep();
            DailyDiningBundleGetByIdRep = new DailyDiningBundleGetByIdRep();
            AddHousKeepingRep = new AddHousKeepingRep();
            GetGetKeepHousingByID = new GetKeepHousingByID();
            getDialyByUser = new GetDialyByUser();
            RemoveDailyDiningBundleGetByIdRep = new RemoveDailyDiningBundleRep();
            EditDailyDiningBundleRep = new EditDailyDiningBundleRep();
            AddMailByIDMenue = new AddMailByIDMenue();
        }

        List<DailyDiningBundle> Data = new();
        
        Dictionary<DailyDiningBundleType, int?> keyValuePairs = new Dictionary<DailyDiningBundleType, int?>();
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
                checkBox4.Checked=false;
                checkBox5.Checked=false;
                checkBox6.Checked=false;
            }

            if(CheckFoodMenue.ReserveFoodID !=0)
            {

            }

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            checkBox1.Checked=false;
            checkBox2.Checked=false;
            checkBox3.Checked=false;
            checkBox3.Checked=false;
            checkBox4.Checked=false;
            checkBox5.Checked=false;
            checkBox6.Checked=false;
            if (CheckFoodMenue.ReserveFoodID !=0)
            {
                Data= getDialyByUser.Get();
                foreach (var item in Data)
                {
                    if (item.Type == DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.break_fast)
                    {
                        checkBox1.Checked=true;
                        textBox1.Text =((double)item.Price/7).ToString();
                    }
                    else if (item.Type == DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.dinner)
                    {
                        checkBox2.Checked=true;
                        textBox2.Text =((double)item.Price/15).ToString();

                    }
                    else if (item.Type == DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.lunch)
                    {

                        checkBox3.Checked=true;
                        textBox3.Text =((double)item.Price/15).ToString();

                    }
                }
                var KeepHousing = GetGetKeepHousingByID.GetHousekeepingByID(CheckFoodMenue.KeepHousingID);
                if (KeepHousing.cleaning==true)
                    checkBox4.Checked = true;
                else
                    checkBox4.Checked = false;

                if (KeepHousing.towel==true)
                    checkBox5.Checked = true;
                else
                    checkBox5.Checked= false;

                if (KeepHousing.s_surprise==true)
                    checkBox6.Checked= true;
                else
                    checkBox6.Checked = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CheckFoodMenue.ReserveFoodID ==0)
            {
                if (checkBox1.Checked==true)
                    dailyDiningBundleVM.Add(new DailyDiningBundleVM() { Type = DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.break_fast, Price=7, Count=int.Parse(textBox1.Text) });
                if (checkBox2.Checked==true)
                    dailyDiningBundleVM.Add(new DailyDiningBundleVM() { Type = DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.lunch, Price=15, Count=int.Parse(textBox2.Text) });
                if (checkBox3.Checked==true)
                    dailyDiningBundleVM.Add(new DailyDiningBundleVM() { Type = DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.dinner, Price=15, Count=int.Parse(textBox3.Text) });

                CheckClean list = new CheckClean();
                if (checkBox4.Checked==true)
                    list.cleaning = true;
                else
                    list.cleaning = false;

                if (checkBox5.Checked==true)
                    list.towel = true;
                else
                    list.towel = false;

                if (checkBox6.Checked==true)
                    list.s_surprise = true;
                else
                    list.s_surprise = false;
                AddHousKeepingRep.Add(list);
                AddDailyDiningBundleRep.Add(dailyDiningBundleVM);
                
            }
            else
            {
                foreach (var item in Data)
                {
                    if (checkBox1.Checked==true)
                        if(item.Type== DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.break_fast)
                        {

                            AddMailByIDMenue.Add(new() { Price=7*int.Parse(textBox1.Text), MealInfoID =CheckFoodMenue.ReserveFoodID, Type=DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.break_fast });
                        }
                       
                           



                    if (checkBox2.Checked==true)
                        if (item.Type== DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.lunch)
                        {
                            item.Price=7*int.Parse(textBox2.Text);

                        }
                    if (checkBox3.Checked==true)
                        if (item.Type== DAL.Entities.Reservations.Foods.Enum.DailyDiningBundleType.dinner)
                        {
                            item.Price=7*int.Parse(textBox3.Text);

                        }
                }



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
