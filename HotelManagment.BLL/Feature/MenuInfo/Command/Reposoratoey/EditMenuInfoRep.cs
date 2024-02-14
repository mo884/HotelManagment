using HotelManagment.BLL.Feature.MenuInfo.Command.Interface;
using HotelManagment.BLL.Feature.MenuInfo.ModelVM;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.MenuInfo.Command.Reposoratoey
{
    public class EditMenuInfoRep : IEditMenuInfoRep
    {
        private readonly HotelDBContext hotelDBContext;
        public EditMenuInfoRep()
        {
            hotelDBContext = new HotelDBContext();
        }
        public void Edit(MenuInfoVM menuInfoVM)
        {
           var Data =  hotelDBContext.MealInfos.Where(a => a.ID == menuInfoVM.ID).FirstOrDefault();
            if (Data is not null)
                Data.Countbreak_fast =menuInfoVM.Countbreak_fast;
            Data.Countdinner = menuInfoVM.Countdinner;
            Data.Countlunch = menuInfoVM.Countlunch;
            Data.FoodBill = menuInfoVM.FoodBill;
            Data.Isbreak_fast = menuInfoVM.Isbreak_fast;
            Data.Isdinner = menuInfoVM.Isdinner;
            Data.Islunch = menuInfoVM.Islunch;
            Data.Pricebreak_fast = menuInfoVM.Pricebreak_fast*menuInfoVM.Countbreak_fast;

            Data.Pricedinner = menuInfoVM.Pricedinner* menuInfoVM.Countdinner;
            Data.Pricelunch= menuInfoVM.Pricelunch*menuInfoVM.Countlunch;
            hotelDBContext.SaveChanges();


        }
    }
}
