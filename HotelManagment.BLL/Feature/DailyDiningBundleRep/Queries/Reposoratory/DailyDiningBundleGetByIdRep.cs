using HotelManagment.BLL.Feature.DailyDiningBundleRep.ModelVM;
using HotelManagment.BLL.Feature.DailyDiningBundleRep.Queries.Interface;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.Reservations.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.DailyDiningBundleRep.Queries.Reposoratory
{
    public class DailyDiningBundleGetByIdRep : IDailyDiningBundleGetByIdRep
    {
        private readonly HotelDBContext HotelDBContext;
        public DailyDiningBundleGetByIdRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public DailyDiningBundleGetByIdVM GetBYID()
        {
            var Data = HotelDBContext.MealInfos.Include(a => a.DailyDiningBundle).FirstOrDefault();
           
            return new DailyDiningBundleGetByIdVM() { ID =Data.ID, FoodBill=Data.FoodBill, DailyDiningBundle=Data.DailyDiningBundle };



        }
    }
}
