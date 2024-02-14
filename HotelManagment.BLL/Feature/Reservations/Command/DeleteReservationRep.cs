using HotelManagment.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Reservations.Command
{
    public class DeleteReservationRep : IDeleteReservationRep
    {
        private readonly HotelDBContext hotelDBContext;
        public DeleteReservationRep()
        {
            hotelDBContext = new HotelDBContext();
        }
        public void Delete(int? RoomID,int? GuestID,int? MenuID)
        {
            var Data = hotelDBContext.Resrvations.Where(a => a.MealInfoID ==MenuID&&a.GuestID==GuestID&&a.RoomID==RoomID).FirstOrDefault();
            if (Data != null)
            {
                hotelDBContext.Resrvations.Remove(Data);
                hotelDBContext.SaveChanges();
            }
        }
    }
}
