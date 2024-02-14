using HotelManagment.BLL.Feature.OverView.Command.Interface;
using HotelManagment.BLL.Feature.OverView.Command.Reposoratory;
using HotelManagment.BLL.Feature.Reservations.Queries.Interface;
using HotelManagment.BLL.Feature.Reservations.Queries.Reposoratory;
using HotelManagment.BLL.Helpers;
using HotelManagment.PLL;
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

namespace HotelManagement.WindowsFormsUI
{
    public partial class Kitchen : Form
    {
        IGetAllReservationRepo getAllReservationRepo;
        IGetAllReservationRepGrid getAllReservationRepGrid;
        public Kitchen()
        {
            InitializeComponent();
            getAllReservationRepo = new GetAllReservationRepo();
            getAllReservationRepGrid =new GetAllReservationRepoGrid();
        }

        private void Kitchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void queueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedData = queueListBox.SelectedItem?.ToString();

            if (selectedData != null)
            {
                // Split the selected item string
                string[] parts = selectedData.Split('/');

                // Extract the required data
                string ID = parts[0];
                string Fname = parts[1];
                string Lname = parts[2];
                CheckFoodMenue.ReserveFoodID =int.Parse(ID);
                string RoomID = parts[3];
                string PhoneNum = parts[4];
                string RoomType = parts[5];
                string Roomfloor = parts[6];
                string LunchCount = parts[7];
                string BreakFastCount = parts[8];
                string DinnerCount = parts[9];
                string IsClean = parts[10];
                string s_surprise = parts[11];
                string towel = parts[12];
                CheckFoodMenue.KeepHousingID =int.Parse(parts[13]);
                firstNameTextBox.Text = Fname;
                lastNameTextBox.Text = Lname;
                floorNTextBox.Text=Roomfloor;
                roomNTextBox.Text = RoomID;
                roomTypeTextBox.Text = RoomType;
                phoneNTextBox.Text=PhoneNum;
                breakfastTextBox.Text =BreakFastCount;
                lunchTextBox.Text = LunchCount;
                dinnerTextBox.Text = DinnerCount;
                if (IsClean=="True")
                {
                    cleaningCheckBox.Checked = true;
                }
                else
                {
                    cleaningCheckBox.Checked=false;
                }
                if (s_surprise=="True")
                {
                    surpriseCheckBox.Checked = true;
                }
                else
                {
                    surpriseCheckBox.Checked=false;
                }
                if (towel=="True")
                {
                    towelCheckBox.Checked = true;
                }
                else
                {
                    towelCheckBox.Checked=false;
                }
            }
            foodSelectionButton.Visible=true;

        }

        private void Kitchen_Load(object sender, EventArgs e)
        {

            this.overviewDataGridView.DataSource=getAllReservationRepGrid.Get();
            var Data = getAllReservationRepo.GetAll();

            foreach (var item in Data)
            {
                string ID = item.MealInfoID.ToString();
                string Fname = item.Guest.First_name;
                string LName = item.Guest.Last_name;
                string RoomID = item.Room.RoomTypeID.ToString();
                string FoodRice = item.MealInfo.FoodBill.ToString();
                string PhoneNum = item.Guest.Phone_number.ToString();
                string RoomType = item.Room.RoomType.room_type.ToString();
                string Roomfloor = item.Room.RoomType.room_floor;
                string LunchCount = item.MealInfo.Countlunch.ToString();
                string BreakFastCount = item.MealInfo.Countbreak_fast.ToString();
                string DinnerCount = item.MealInfo.Countdinner.ToString();
                string IsClean = item.Housekeeping.cleaning.ToString();
                string s_surprise = item.Housekeeping.s_surprise.ToString();
                string towel = item.Housekeeping.towel.ToString();
                string KeepHous = item.HousekeepingID.ToString();
                queueListBox.Items.Add($"{ID}/{Fname}/{LName}/{RoomID}/{PhoneNum}/{RoomType}/{Roomfloor}/{LunchCount}/{BreakFastCount}/{DinnerCount}/{IsClean}/{s_surprise}/{towel}/{KeepHous}");
            }
        }

        private void foodSelectionButton_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm();
            foodForm.ShowDialog();
        }
    }
}
