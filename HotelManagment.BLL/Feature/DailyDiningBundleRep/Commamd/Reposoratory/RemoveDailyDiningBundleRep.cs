using HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Interface;
using HotelManagment.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.DailyDiningBundleRep.Commamd.Reposoratory
{
    public class RemoveDailyDiningBundleRep : IRemoveDailyDiningBundleRep
    {
        private readonly HotelDBContext HotelDBContext;
        public RemoveDailyDiningBundleRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Delete(int ID)
        {
            var Data = HotelDBContext.DailyDiningBundle.Where(a=>a.ID == ID).FirstOrDefault();
            HotelDBContext.DailyDiningBundle.Remove(Data);
            HotelDBContext.SaveChanges();
        }
    }
}
