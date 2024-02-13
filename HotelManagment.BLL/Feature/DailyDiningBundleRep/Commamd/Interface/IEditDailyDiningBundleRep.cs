using HotelManagment.BLL.Feature.DailyDiningBundleRep.ModelVM;
using HotelManagment.DAL.Entities.Reservations.Foods.Enum;
using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Interface
{
    public interface IEditDailyDiningBundleRep
    {
        void update(List<DailyDiningBundle> dailyDiningBundles);
    }
}
