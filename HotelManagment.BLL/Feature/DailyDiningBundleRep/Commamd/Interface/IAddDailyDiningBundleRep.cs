using HotelManagment.BLL.Feature.DailyDiningBundleRep.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Interface
{
    public interface  IAddDailyDiningBundleRep
    {
        void Add(List<DailyDiningBundleVM> dailyDiningBundleVM );
    }
}
