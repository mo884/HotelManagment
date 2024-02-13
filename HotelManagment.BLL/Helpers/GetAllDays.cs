using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Helpers
{
    public static class GetAllDays
    {
        public static List<Days> GetAllDay()
        {
            List<Days> days = new List<Days>();

            for (int day = 1; day <32; day++) 
            {
                Days dayVM = new Days { Name =day.ToString() };
                days.Add(dayVM);
            }
            return days;
        }
    }
}
