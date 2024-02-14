using HotelManagment.BLL.Feature.MenuInfo.ModelVM;
using HotelManagment.BLL.Feature.MenuInfo.Queries.Interface;
using HotelManagment.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.MenuInfo.Queries.Reposoratoey
{
    public class GetMenuInfoRepoBYID : IGetMenuInfoRepoBYID
    {
        private readonly HotelDBContext hotelDBContext;
        public GetMenuInfoRepoBYID()
        {
            hotelDBContext = new HotelDBContext();
        }
        public MenuInfoVM Get(int id)
        {
            var Data = hotelDBContext.MealInfos.Where(a=>a.ID== id).FirstOrDefault();
            MenuInfoVM menuInfoVM = new MenuInfoVM()
            {
                ID = Data.ID,
                Countbreak_fast = Data.Countbreak_fast,
                Countdinner = Data.Countdinner,
                Countlunch = Data.Countlunch,
                FoodBill = Data.FoodBill,
                Isbreak_fast = Data.Isbreak_fast,
                Isdinner = Data.Isdinner,
                Islunch = Data.Islunch,
                Pricebreak_fast = Data.Pricebreak_fast, 
                Pricedinner = Data.Pricedinner,
                Pricelunch = Data.Pricelunch,
            };
            return menuInfoVM;
        }
    }
}
