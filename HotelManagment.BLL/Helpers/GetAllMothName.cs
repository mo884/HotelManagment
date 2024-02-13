using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Helpers
{
    public static class GetAllMothName
    {
        public static List<MonthVM> GetAllMonth()
        {
            List<MonthVM> months = new List<MonthVM>();

            // Loop through each month and add its name to the list
            for (int month = 1; month <= 12; month++)
            {
                MonthVM monthVM = new() { Name = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month) };
                months.Add(monthVM);
            }
            return months;
        }
    }
}
