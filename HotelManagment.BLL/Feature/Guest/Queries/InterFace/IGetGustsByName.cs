using HotelManagment.BLL.Feature.Reservations.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Guest.Queries.InterFace
{
    public interface IGetGustsByName
    {
        List<ReservationVM >Get(string name);
    }
}
