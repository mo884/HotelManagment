using HotelManagment.BLL.Feature.Reservations.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Reservations.Command
{
    public interface IEditeReservationRep
    {
        void Edite(ReservationVM reservationVM);
    }
}
