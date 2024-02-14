using HotelManagment.BLL.Feature.HousKeepingRep.Command.Interface;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.HousKeepingRep.Command.Reposoratory
{
    public class EditHousKepingRep : IEditHousKepingRep
    {
        private readonly HotelDBContext HotelDBContext;
        public EditHousKepingRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Edit(Housekeeping housekeeping)
        {
            var Data= HotelDBContext.Housekeeping.Where(a=>a.ID==housekeeping.ID).FirstOrDefault();
            Data.cleaning =housekeeping.cleaning;
            Data.towel=housekeeping.towel;
            Data.s_surprise =housekeeping.s_surprise;
            HotelDBContext.SaveChanges();
        }
        
    }
}
