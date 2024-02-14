using HotelManagment.BLL.Feature.MenuInfo.Command.Interface;
using HotelManagment.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.MenuInfo.Command.Reposoratoey
{
    public class DeleteMenuInfoRepo: IDeleteMenuInfoRepo
    {
        private readonly HotelDBContext hotelDBContext;
        public DeleteMenuInfoRepo()
        {
            hotelDBContext = new HotelDBContext();
        }
        public void Delete(int ID)
        {
            var Data = hotelDBContext.MealInfos.Where(a => a.ID == ID).FirstOrDefault();
            hotelDBContext.MealInfos.Remove(Data);
            hotelDBContext.SaveChanges();

        }
    }
}
