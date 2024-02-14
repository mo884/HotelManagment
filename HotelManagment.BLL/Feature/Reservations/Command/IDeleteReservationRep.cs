using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Reservations.Command
{
    public interface IDeleteReservationRep
    {
        void Delete(int? RoomID, int? GuestID, int? MenuID);
    }
}
