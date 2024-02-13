using HotelManagment.BLL.Feature.DailyDiningBundleRep.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Helpers
{
    public static class CheckFoodMenue
    {
        public static int GuestID { get; set; }
        public static int RoomID { get; set; }
        public static int ReserveFoodID {  get; set; }
        public static int KeepHousingID { get; set; }

        public static DailyDiningBundleVM DailyDiningBundleVM { get; set; }
    }
}
