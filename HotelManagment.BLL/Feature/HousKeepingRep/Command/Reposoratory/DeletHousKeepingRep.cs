using HotelManagment.BLL.Feature.HousKeepingRep.Command.Interface;
using HotelManagment.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.HousKeepingRep.Command.Reposoratory
{
    public class DeletHousKeepingRep : IDeletHousKeepingRep
    {
        private readonly HotelDBContext hotelDBContext;
        public DeletHousKeepingRep()
        {
            hotelDBContext = new HotelDBContext();
        }
        public void Delete(int ID)
        {
            var Data = hotelDBContext.Housekeeping.Where(a=>a.ID == ID).FirstOrDefault();
            hotelDBContext.Housekeeping.Remove(Data);
            hotelDBContext.SaveChanges();

        }
    }
}
