using HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Interface;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Reposoratory
{
    public class AddMailByIDMenue : IAddMailByIDMenue
    {
        private readonly HotelDBContext HotelDBContext;
        public AddMailByIDMenue()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Add(DailyDiningBundle dailyDiningBundle)
        {
            HotelDBContext.DailyDiningBundle.Add(dailyDiningBundle);
            HotelDBContext.SaveChanges();
        }
    }
}
