using HotelManagment.BLL.Feature.OverView.Command.Interface;
using HotelManagment.BLL.Feature.OverView.ModelVM;
using HotelManagment.BLL.Feature.Reservations.Queries.Interface;
using HotelManagment.BLL.Feature.Reservations.Queries.Reposoratory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.OverView.Command.Reposoratory
{
    public class GetAllReservationRepoGrid : IGetAllReservationRepGrid
    {
        IGetAllReservationRepo getAllReservationRepo;
        public GetAllReservationRepoGrid()
        {
            getAllReservationRepo = new GetAllReservationRepo();
        }
        public List<ReservationGrid> Get()
        {
            List<ReservationGrid> reservationGrids = new List<ReservationGrid>();
           var Data = getAllReservationRepo.GetAll();
            foreach (var DataGrid in Data)
            {
                ReservationGrid reservationGrid = new ReservationGrid()
                {
                    Birth_day =DataGrid.Guest.Birth_day,
                    First_name=DataGrid.Guest.First_name,
                    Last_name=DataGrid.Guest.Last_name,
                    Phone_number =DataGrid.Guest.Phone_number,
                    email_address=DataGrid.Guest.email_address,
                    RoomTypeID=DataGrid.Room.RoomTypeID,
                    room_floor=DataGrid.Room.RoomType.room_floor,
                    Countbreak_fast=DataGrid.MealInfo.Countbreak_fast,
                    Countdinner=DataGrid.MealInfo.Countdinner,
                    Countlunch=DataGrid.MealInfo.Countlunch,
                    FoodBill=DataGrid.MealInfo.FoodBill,
                    Gender=DataGrid.Guest.Gender,
                    Price =DataGrid.MealInfo.FoodBill,
                    room_type=DataGrid.Room.RoomType.room_type
                };
                reservationGrids.Add(reservationGrid);
            }

            return reservationGrids;
        }
    }
}
