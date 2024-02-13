using HotelManagment.BLL.Feature.HousKeepingRep.Queries.Interface;
using HotelManagment.BLL.Helpers;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.HousKeepingRep.Queries.Reposoratory
{
    public class GetKeepHousingByID : IGetKeepHousingByID
    {
        private readonly HotelDBContext HotelDBContext;
        public GetKeepHousingByID()
        {
            HotelDBContext = new HotelDBContext();
        }
        public Housekeeping GetHousekeepingByID(int id)
        {
            var data = HotelDBContext.Housekeeping.Where(a=>a.ID==CheckFoodMenue.KeepHousingID).FirstOrDefault();
            return data;
        }
    }
}
