using HotelManagment.BLL.Feature.City.ModelVM;
using HotelManagment.BLL.Feature.City.Quieries.Interface;
using HotelManagment.BLL.Feature.City.Quieries.Reposoratory;
using HotelManagment.BLL.Feature.Guest.Command.InterFace;
using HotelManagment.BLL.Feature.Guest.Command.Reposoratory;
using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.BLL.Feature.RoomRep.Queries.Interface;
using HotelManagment.BLL.Feature.RoomRep.Queries.Reposoratory;
using HotelManagment.BLL.Feature.State.Quieries.Interface;
using HotelManagment.BLL.Feature.State.Quieries.Reposoratory;
using HotelManagment.BLL.Feature.Streets.ModelVM;
using HotelManagment.BLL.Feature.Streets.Quieries.Interface;
using HotelManagment.BLL.Feature.Streets.Quieries.Reposoratory;
using HotelManagment.BLL.Helpers;
using HotelManagment.DAL.Entities.Adress;
using HotelManagment.DAL.Entities.GuestInfo.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment.PLL
{
    public partial class FrontEndUI : Form
    {
        IAddGuestRep addGuestRep;
        IGetAllStateRep getAllStateRep;
        IGetStreetByCityName GetStreetByCityName;
        IGetAllRoomRep getAllRoomRep;
        
        private FoodForm foodForm;
        public FrontEndUI()
        {
            InitializeComponent();

            getAllStateRep = new GetAllStateRep();
            GetStreetByCityName = new GetStreetByCityName();
            addGuestRep = new AddGuestRep();
            getAllRoomRep = new GetAllRoomRep();
            dateTimePicker4.MinDate = DateTime.Today;
            dateTimePicker3.MinDate = DateTime.Today.AddDays(1);
            foodForm = new FoodForm();
        }




        BindingSource StreetBinding;
        BindingSource StateBinding;
        BindingSource RoomBinding;
        private void FrontEndUI_Load(object sender, EventArgs e)
        {
            GenderCombo.DataSource =GetAllGender.Getgenders();
            MonthCombo.DataSource = GetAllMothName.GetAllMonth();
            MonthCombo.ValueMember = "Name";
            DayCombo.DataSource= GetAllDays.GetAllDay();
            DayCombo.ValueMember = "Name";

            var AllState = getAllStateRep.GetAll();
            StateBinding = new BindingSource(AllState, "");
            StateName.DataSource = StateBinding;
            StateName.ValueMember ="StateName";
            ZipCodeCombo.DataBindings.Add("Text", StateBinding, "ZIbCode");
            ComboCityName.DataBindings.Add("DataSource", StateBinding, "cities");
            ComboCityName.ValueMember = "CityName";
            object ext = ComboCityName.SelectedValue;
            var Stre = GetStreetByCityName.Get(ComboCityName.SelectedValue.ToString());
            var selectedCity = ComboCityName.SelectedValue?.ToString();
            ComboCityName.SelectionChangeCommitted += ComboCityName_SelectionChangeCommitted;

            //////////////////////////////////////////////////////
            ///

            RoomBinding = new BindingSource(getAllRoomRep.Get(), "");
            RoomNUMID.DataSource =RoomBinding;
            RoomNUMID.ValueMember= "room_number";
            RoomType.DataBindings.Add("Text", RoomBinding, "RoomType.room_type");
            Floor.DataBindings.Add("Text", RoomBinding, "RoomType.room_floor");
            RoomPrice.DataBindings.Add("Text", RoomBinding, "RoomType.Price");
        }
        private void ComboCityName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedCity = ComboCityName.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(selectedCity))
            {
                var streets = GetStreetByCityName.Get(selectedCity);
                Street_AdressCombo.DataSource = streets;
                Street_AdressCombo.DisplayMember = "Street_Adress";
            }
        }
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            var StreetsSelect = (Street_AdressCombo.SelectedItem) as GetStreetByCityNameVM;
            AddGuestVM addGuestVM = new AddGuestVM()
            {

                First_name = FName.Text,
                Last_name = FName.Text,
                Birth_day= $"{DayCombo.SelectedValue}/{MonthCombo.SelectedValue}/{YearText.Text}",
                email_address = EmailAdress.Text,
                Gender=(Gender)GenderCombo.SelectedValue,
                Phone_number = PhoneNum.Text,
                StreetID =StreetsSelect.ID
            };
            addGuestRep.Add(addGuestVM);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            CheckFoodMenue.ReserveFoodID = 8;
            CheckFoodMenue.GuestID=1;
            foodForm.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ReservationFormPanal.Visible=true;
            ReservationFormPanal.Location = new Point(226, 3);

            SearchPanal.Location = new Point(99314, 9107);
            SearchPanal.Visible=false;

            GridPanel.Location = new Point(4556, 0);
            GridPanel.Visible=false;

            AvailabilityPanel.Location = new Point(7786, 0);
            AvailabilityPanel.Visible=false;

            Color color = Color.FromArgb(35, 40, 45);
            this.button5.BackColor = Color.LightSeaGreen;
            this.button5.ForeColor =Color.White;

            this.button1.BackColor = color;
            this.button1.ForeColor =Color.LightSeaGreen;
            this.button2.BackColor = color;
            this.button2.ForeColor =Color.LightSeaGreen;


            this.button3.BackColor = color;
            this.button3.ForeColor =Color.LightSeaGreen;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SearchPanal.Location = new Point(314, 107);
            SearchPanal.Visible=true;
            GridPanel.Location = new Point(4556, 0);
            GridPanel.Visible=false;
            ReservationFormPanal.Visible=false;
            ReservationFormPanal.Location = new Point(56726, 3);
            AvailabilityPanel.Location = new Point(7786, 0);
            AvailabilityPanel.Visible=false;

            Color color = Color.FromArgb(35, 40, 45);
            this.button1.BackColor = Color.LightSeaGreen;
            this.button1.ForeColor =Color.White;
            this.button5.BackColor = color;
            this.button5.ForeColor =Color.LightSeaGreen;

            this.button2.BackColor = color;
            this.button2.ForeColor =Color.LightSeaGreen;

            this.button3.BackColor = color;
            this.button3.ForeColor =Color.LightSeaGreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridPanel.Location = new Point(226, 0);
            GridPanel.Visible=true;
            ReservationFormPanal.Visible=false;
            ReservationFormPanal.Location = new Point(56726, 3);
            SearchPanal.Location = new Point(99314, 9107);
            SearchPanal.Visible=false;
            AvailabilityPanel.Location = new Point(7786, 0);
            AvailabilityPanel.Visible=false;
            Color color = Color.FromArgb(35, 40, 45);
            this.button2.BackColor = Color.LightSeaGreen;
            this.button2.ForeColor =Color.White;

            this.button5.BackColor = color;
            this.button5.ForeColor =Color.LightSeaGreen;

            this.button1.BackColor = color;
            this.button1.ForeColor =Color.LightSeaGreen;

            this.button3.BackColor = color;
            this.button3.ForeColor =Color.LightSeaGreen;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            AvailabilityPanel.Location = new Point(226, 0);
            AvailabilityPanel.Visible=true;
            ReservationFormPanal.Visible=false;
            ReservationFormPanal.Location = new Point(56726, 3);
            SearchPanal.Location = new Point(99314, 9107);
            SearchPanal.Visible=false;
            GridPanel.Location = new Point(4556, 0);
            GridPanel.Visible=false;


            Color color = Color.FromArgb(35, 40, 45);
            this.button3.BackColor = Color.LightSeaGreen;
            this.button3.ForeColor =Color.White;

            this.button1.BackColor = color;
            this.button1.ForeColor =Color.LightSeaGreen;
            this.button2.BackColor = color;
            this.button2.ForeColor =Color.LightSeaGreen;

            this.button5.BackColor = color;
            this.button5.ForeColor =Color.LightSeaGreen;
        }

        
    }
}
