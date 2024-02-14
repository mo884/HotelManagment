using HotelManagment.BLL.Feature.Reservations.ModelVM;
using HotelManagment.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Reservations.Command
{
    public class EditeReservationRep : IEditeReservationRep
    {
        private readonly HotelDBContext HotelDBContext;
        public EditeReservationRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Edite(ReservationVM reservationVM)
        {
            var Data =HotelDBContext.Resrvations.Where(a=>a.RoomID==reservationVM.RoomID&&a.GuestID==reservationVM.GuestID&&a.GuestID==reservationVM.GuestID).FirstOrDefault();

            Data.arrival_time = reservationVM.arrival_time;
            Data.leaving_time = reservationVM.leaving_time;
            Data.RoomID = reservationVM.RoomID;
            HotelDBContext.SaveChanges();
        }
    }
}
