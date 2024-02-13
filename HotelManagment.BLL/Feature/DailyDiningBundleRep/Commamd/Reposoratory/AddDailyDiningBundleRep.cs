using HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Interface;
using HotelManagment.BLL.Feature.DailyDiningBundleRep.ModelVM;
using HotelManagment.BLL.Helpers;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Reposoratory
{
    public class AddDailyDiningBundleRep : IAddDailyDiningBundleRep
    {
        private readonly HotelDBContext HotelDBContext;
        public AddDailyDiningBundleRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Add(List<DailyDiningBundleVM> dailyDiningBundleVM)
        {
            HotelDBContext.MealInfos.Add(new());
            HotelDBContext.SaveChanges();
           

            var Data = HotelDBContext.MealInfos.OrderByDescending(mi => mi.ID).LastOrDefault();
            decimal Count =0;
            foreach (var item in dailyDiningBundleVM)
            {
                DailyDiningBundle diningBundle = new DailyDiningBundle()
                {
                    MealInfoID  = Data.ID,
                    Type = item.Type,
                    Price = item.Price,
                };
                Count += item.Count *item.Price;
                HotelDBContext.DailyDiningBundle.Add(diningBundle);
            }
            Data.FoodBill = Count;
            HotelDBContext.SaveChanges();
            CheckFoodMenue.ReserveFoodID = Data.ID;
        }
    }
}
