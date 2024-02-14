using HotelManagment.BLL.Feature.City.ModelVM;
using HotelManagment.BLL.Feature.City.Quieries.Interface;
using HotelManagment.BLL.Feature.City.Quieries.Reposoratory;
using HotelManagment.BLL.Feature.Guest.Command.InterFace;
using HotelManagment.BLL.Feature.Guest.Command.Reposoratory;
using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.BLL.Feature.Guest.Queries.InterFace;
using HotelManagment.BLL.Feature.Guest.Queries.Reposoratory;
using HotelManagment.BLL.Feature.Reservations.Command;
using HotelManagment.BLL.Feature.Reservations.ModelVM;
using HotelManagment.BLL.Feature.Reservations.Queries.Interface;
using HotelManagment.BLL.Feature.Reservations.Queries.Reposoratory;
using HotelManagment.BLL.Feature.RoomRep.Queries.Interface;
using HotelManagment.BLL.Feature.RoomRep.Queries.Reposoratory;
using HotelManagment.BLL.Feature.State.ModelVM;
using HotelManagment.BLL.Feature.State.Quieries.Interface;
using HotelManagment.BLL.Feature.State.Quieries.Reposoratory;
using HotelManagment.BLL.Feature.Streets.ModelVM;
using HotelManagment.BLL.Feature.Streets.Quieries.Interface;
using HotelManagment.BLL.Feature.Streets.Quieries.Reposoratory;
using HotelManagment.BLL.Helpers;
using HotelManagment.DAL.Entities.GuestInfo.Enum;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace HotelManagment.PLL
{
    public partial class FrontEndUI : Form
    {
        IAddGuestRep addGuestRep;
        IGetAllStateRep getAllStateRep;
        IGetStreetByCityName GetStreetByCityName;
        IGetAllRoomRep getAllRoomRep;
        IGetAllGuestRep getAllGuestRep;
        IAddReservation addReservation;
        IGetAllCityRep getAllCityRep;
        IGetAllReservationRepo getAllReservationRepo;
        IGetAllStreets getAllStreets;

        private FoodForm foodForm;
        public FrontEndUI()
        {
            InitializeComponent();
            getAllReservationRepo = new GetAllReservationRepo();
            getAllStateRep = new GetAllStateRep();
            GetStreetByCityName = new GetStreetByCityName();
            addGuestRep = new AddGuestRep();
            getAllRoomRep = new GetAllRoomRep();
            getAllGuestRep = new GetAllGuestRep();
            addReservation = new AddReservationRep();
            getAllCityRep = new GetAllCity();
            getAllStreets = new GetAllStreets();
           
            foodForm = new FoodForm();
            StateBindingvar  = new BindingSource(getAllStateRep.GetAll(), "");
        }



      
        BindingSource StreetBinding;
        BindingSource StateBindingvar;
        BindingSource RoomBinding;
        BindingSource BindingSource;
        BindingSource StreetsBind;

        private void FrontEndUI_Load(object sender, EventArgs e)
        {
            //panel2.Visible=false;
            var Data = getAllReservationRepo.GetAll();
            BindingSource = new BindingSource(Data, "");
            comboBox13.DataSource = BindingSource;
            comboBox13.ValueMember ="leaving_time";

            LName.DataBindings.Add("Text", BindingSource, "Guest.Last_name");
            FName.DataBindings.Add("Text", BindingSource, "Guest.First_name");
            GenderCombo.DataBindings.Add("SelectedValue", BindingSource, "Guest.Gender");
            Phone.DataBindings.Add("Text", BindingSource, "Guest.Phone_number");
            textBox6.DataBindings.Add("Text", BindingSource, "Guest.Emai");
            button19.Visible=false;
            panel1.Visible=true;
            GenderCombo.DataSource =GetAllGender.Getgenders();
            MonthCombo.DataSource = GetAllMothName.GetAllMonth();
            MonthCombo.ValueMember = "Name";
            DayCombo.DataSource= GetAllDays.GetAllDay();
            DayCombo.ValueMember = "Name";
            CheckFoodMenue.GuestID= Data.FirstOrDefault().GuestID;
            CheckFoodMenue.ReserveFoodID = Data.FirstOrDefault().MealInfoID;
            CheckFoodMenue.RoomID=Data.FirstOrDefault().RoomID;
            CheckFoodMenue.KeepHousingID=Data.FirstOrDefault().HousekeepingID;

            comboBox13.SelectedValueChanged += (sender, e) =>
            {
                if (comboBox13.SelectedValue != null)
                {
                    var selectedLeavingTime = comboBox13.SelectedValue.ToString(); // Assuming leaving_time is string

                    // Assuming comboBox13 is bound to a collection of objects of a class called Reservation
                    // You may need to adjust this according to your actual implementation
                    var reservation = comboBox13.SelectedItem as ReservationVM;
                    var Data = reservation;
                    StateName.SelectedValue = Data.Guest.Streets.City.State.StateName;
                    ZipCodeCombo.Text=Data.Guest.Streets.City.State.ZIbCode;
                    Street_AdressCombo.SelectedValue =Data.Guest.Streets.Street_Adress;
                    ComboCityName.SelectedValue=Data.Guest.Streets.City.CityName;
                    ComboCityName.SelectionChangeCommitted += ComboCityName_SelectionChangeCommitted;
                    RoomNUMID.SelectedValue  = Data.Room.RoomTypeID.ToString();
                    RoomType.Text = Data.Room.RoomType.room_type.ToString();
                    Floor.Text=Data.Room.RoomType.room_floor.ToString();
                    RoomPrice.Text = Data.Room.RoomType.Price.ToString();
                  
                    CheckFoodMenue.GuestID=Data.GuestID;
                    CheckFoodMenue.ReserveFoodID = Data.MealInfoID;
                    CheckFoodMenue.RoomID=Data.RoomID;
                    CheckFoodMenue.KeepHousingID=Data.HousekeepingID;
                }
            };
            var AllState = getAllStateRep.GetAll();
          
            StateName.DataSource = StateBindingvar;
            StateName.ValueMember ="StateName";
            StreetsBind  = new BindingSource(getAllStreets.GetAll(), "");
            Street_AdressCombo.DataSource = StreetsBind;
            Street_AdressCombo.ValueMember = "Street_Adress";
            ZipCodeCombo.DataBindings.Add("Text", StateBindingvar, "ZIbCode");
            ComboCityName.DataBindings.Add("DataSource", StateBindingvar, "cities");
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
            var room = getAllRoomRep.Get().Where(a => a.room_number==RoomNUMID.SelectedValue.ToString()).FirstOrDefault();
            CheckFoodMenue.RoomID =room.ID;
            if (CheckFoodMenue.ReserveFoodID !=0)
            {
                addReservation.Add(new() { GuestID = CheckFoodMenue.GuestID, HousekeepingID =CheckFoodMenue.KeepHousingID, MealInfoID=CheckFoodMenue.ReserveFoodID, RoomID=CheckFoodMenue.RoomID, leaving_time=dateTimePicker4.Value, arrival_time=dateTimePicker3.Value, check_in =true });

            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.ShowDialog();
        }
        private void button21_Click(object sender, EventArgs e)
        {


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
