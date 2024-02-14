using HotelManagment.BLL.Feature.OverView.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.OverView.Command.Interface
{
    public interface IGetAllReservationRepGrid
    {
        List<ReservationGrid> Get();
    }
}
