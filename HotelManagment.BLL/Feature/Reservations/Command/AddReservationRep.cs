using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Reservations.Command
{
    public class AddReservationRep : IAddReservation
    {
        private readonly HotelDBContext HotelDBContext;
        public AddReservationRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Add(Resrvations resrvations)
        {
            HotelDBContext.Add(resrvations);
            HotelDBContext.SaveChanges();
        }
    }
}
