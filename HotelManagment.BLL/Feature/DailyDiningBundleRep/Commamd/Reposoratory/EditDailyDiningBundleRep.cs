using HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Interface;
using HotelManagment.BLL.Feature.DailyDiningBundleRep.ModelVM;
using HotelManagment.BLL.Helpers;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.Reservations.Foods.Enum;
using HotelManagment.DAL.Entities.Reservations.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Reposoratory
{
    public class EditDailyDiningBundleRep : IEditDailyDiningBundleRep
    {
        private readonly HotelDBContext HotelDBContext;
        public EditDailyDiningBundleRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void update(List<DailyDiningBundle> dailyDiningBundles)
        {
            decimal? count = 0;
            foreach (var item in dailyDiningBundles)
            {
                count += item.Price;
            }

            var Data = HotelDBContext.MealInfos.Where(a => a.ID == CheckFoodMenue.ReserveFoodID).FirstOrDefault();
            Data.FoodBill =count;
            HotelDBContext.SaveChanges();
        }
    }
}
