using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Interface
{
    public interface IAddMailByIDMenue
    {
        void Add(DailyDiningBundle dailyDiningBundle);
    }
}
