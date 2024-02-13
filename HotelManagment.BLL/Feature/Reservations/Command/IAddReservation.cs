using HotelManagment.DAL.Entities.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Reservations.Command
{
    public interface IAddReservation
    {
        void Add(Resrvations resrvations);
    }
}
