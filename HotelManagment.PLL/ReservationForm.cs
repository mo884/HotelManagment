using HotelManagment.BLL.Feature.Guest.Command.InterFace;
using HotelManagment.BLL.Feature.Guest.Command.Reposoratory;
using HotelManagment.BLL.Feature.Guest.Queries.InterFace;
using HotelManagment.BLL.Feature.Guest.Queries.Reposoratory;
using HotelManagment.BLL.Feature.Reservations.Command;
using HotelManagment.BLL.Feature.RoomRep.Queries.Interface;
using HotelManagment.BLL.Feature.RoomRep.Queries.Reposoratory;
using HotelManagment.BLL.Feature.State.Quieries.Interface;
using HotelManagment.BLL.Feature.State.Quieries.Reposoratory;
using HotelManagment.BLL.Feature.Streets.Quieries.Interface;
using HotelManagment.BLL.Feature.Streets.Quieries.Reposoratory;
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
    public partial class ReservationForm : Form
    {
        IAddGuestRep addGuestRep;
        IGetAllStateRep getAllStateRep;
        IGetStreetByCityName GetStreetByCityName;
        IGetAllRoomRep getAllRoomRep;
        IGetAllGuestRep getAllGuestRep;
        IAddReservation addReservation;
        private FoodForm foodForm;

        public ReservationForm()
        {
            InitializeComponent();
            getAllStateRep = new GetAllStateRep();
            GetStreetByCityName = new GetStreetByCityName();
            addGuestRep = new AddGuestRep();
            getAllRoomRep = new GetAllRoomRep();
            getAllGuestRep = new GetAllGuestRep();
            addReservation = new AddReservationRep();
            dateTimePicker4.MinDate = DateTime.Today;
            dateTimePicker3.MinDate = DateTime.Today.AddDays(1);
            foodForm = new FoodForm();
        }
        BindingSource StateBinding;
        BindingSource RoomBinding;
        private void ReservationForm_Load(object sender, EventArgs e)
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
    }
}
