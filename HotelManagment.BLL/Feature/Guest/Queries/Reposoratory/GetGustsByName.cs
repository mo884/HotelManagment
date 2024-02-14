using HotelManagment.BLL.Feature.Guest.Queries.InterFace;
using HotelManagment.BLL.Feature.Reservations.ModelVM;
using HotelManagment.DAL.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Guest.Queries.Reposoratory
{
    public class GetGustsByName : IGetGustsByName
    {
        private readonly HotelDBContext HotelDBContext;
        public GetGustsByName()
        {
            HotelDBContext = new HotelDBContext();
        }
        public List<ReservationVM> Get(string name)
        {
          var Data = HotelDBContext.Guests.Where(a=>a.First_name.Contains(name)||a.Last_name.Contains(name)).Include(a=>a.Resrvations).ToList();
            List<ReservationVM> reservationVMs = new List<ReservationVM>();
            foreach (var date in Data)
            {
                foreach (var item in date.Resrvations)
                {
                    ReservationVM reservationVM = new ReservationVM()
                    {
                        ID = item.ID,
                        GuestID = item.GuestID,
                        Guest = HotelDBContext.Guests.Where(a => a.Id==item.GuestID).Include(a => a.Streets).ThenInclude(a => a.City).ThenInclude(a => a.State).FirstOrDefault(),
                        Housekeeping = HotelDBContext.Housekeeping.Where(a => a.ID==item.HousekeepingID).FirstOrDefault(),
                        arrival_time = item.arrival_time,
                        check_in = item.check_in,
                        HousekeepingID = item.HousekeepingID,
                        MealInfoID = item.MealInfoID,
                        leaving_time = item.leaving_time,
                        MealInfo = HotelDBContext.MealInfos.Where(a => a.ID==item.MealInfoID).FirstOrDefault(),
                        Room =HotelDBContext.Rooms.Where(a => a.ID==item.RoomID).Include(a => a.RoomType).FirstOrDefault(),
                        RoomID= item.RoomID,
                    };
                    reservationVMs.Add(reservationVM);
                }
                
            }
            return reservationVMs;
        }
    }
}
