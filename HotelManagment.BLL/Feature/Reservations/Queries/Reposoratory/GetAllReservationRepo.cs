using HotelManagment.BLL.Feature.Reservations.ModelVM;
using HotelManagment.BLL.Feature.Reservations.Queries.Interface;
using HotelManagment.DAL.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Reservations.Queries.Reposoratory
{
    public class GetAllReservationRepo : IGetAllReservationRepo
    {
        private readonly HotelDBContext hotelDBContext;
        public GetAllReservationRepo()
        {
            hotelDBContext = new HotelDBContext();
        }
        public List<ReservationVM> GetAll()
        {
            var Data = hotelDBContext.Resrvations.Include(a => a.MealInfo).ToList();

            List<ReservationVM> reservationVMs = new List<ReservationVM>();
            foreach (var item in Data)
            {
                ReservationVM reservationVM = new ReservationVM()
                {
                    ID = item.ID,
                    GuestID = item.GuestID,
                    Guest = hotelDBContext.Guests.Where(a=>a.Id==item.GuestID).Include(a => a.Streets).ThenInclude(a=>a.City).ThenInclude(a=>a.State).FirstOrDefault(),
                    Housekeeping = hotelDBContext.Housekeeping.Where(a => a.ID==item.HousekeepingID).FirstOrDefault(),
                    arrival_time = item.arrival_time,
                    check_in = item.check_in,
                    HousekeepingID = item.HousekeepingID,
                    MealInfoID = item.MealInfoID,
                    leaving_time = item.leaving_time,
                    MealInfo = hotelDBContext.MealInfos.Where(a => a.ID==item.MealInfoID).FirstOrDefault(),
                    Room =hotelDBContext.Rooms.Where(a => a.ID==item.RoomID).Include(a=>a.RoomType).FirstOrDefault(),
                    RoomID=item.RoomID,
                };
                reservationVMs.Add(reservationVM);
            }
            return reservationVMs;  
        }
    }
}
