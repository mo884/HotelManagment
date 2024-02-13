using HotelManagment.BLL.Feature.DailyDiningBundleRep.Queries.Interface;
using HotelManagment.BLL.Helpers;
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
    public class GetDialyByUser : IGetDialyByUser
    {
        private readonly HotelDBContext HotelDBContext;
        public GetDialyByUser()
        {
            HotelDBContext = new HotelDBContext();
        }
        public List<DailyDiningBundle> Get()
        {
            var Data= HotelDBContext.MealInfos.Include(a => a.DailyDiningBundle).Where(a => a.ID == CheckFoodMenue.ReserveFoodID).FirstOrDefault();
            return Data.DailyDiningBundle;
        }
    }
}
