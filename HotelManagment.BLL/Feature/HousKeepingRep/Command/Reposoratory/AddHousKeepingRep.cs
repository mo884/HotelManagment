using HotelManagment.BLL.Feature.HousKeepingRep.Command.Interface;
using HotelManagment.BLL.Helpers;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.HousKeepingRep.Command.Reposoratory
{
    public class AddHousKeepingRep : IAddHousKeepingRep
    {
        private readonly HotelDBContext HotelDBContext;
        public AddHousKeepingRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Add(CheckClean checkClean)
        {
            Housekeeping housekeeping = new() { cleaning =checkClean.cleaning, s_surprise =checkClean.s_surprise, towel =checkClean.towel };
            HotelDBContext.Housekeeping.Add(housekeeping);
            HotelDBContext.SaveChanges();
            CheckFoodMenue.KeepHousingID =housekeeping.ID;
        }
    }
}
