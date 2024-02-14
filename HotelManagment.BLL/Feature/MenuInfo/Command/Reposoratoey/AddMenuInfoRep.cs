using HotelManagment.BLL.Feature.MenuInfo.Command.Interface;
using HotelManagment.BLL.Feature.MenuInfo.ModelVM;
using HotelManagment.BLL.Helpers;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.MenuInfo.Command.Reposoratoey
{
    public class AddMenuInfoRep : IAddMenuInfoRep
    {
        private readonly HotelDBContext hotelDBContext;
        public AddMenuInfoRep()
        {
            hotelDBContext = new HotelDBContext();
        }
        public void Add(MenuInfoVM menuInfoVM)
        {
            MealInfo mealInfo = new MealInfo() { 
            Countbreak_fast=menuInfoVM.Countbreak_fast,
            Countdinner = menuInfoVM.Countdinner,
            Countlunch = menuInfoVM.Countlunch,
           
            Isbreak_fast = menuInfoVM.Isbreak_fast,
            Isdinner = menuInfoVM.Isdinner,
            Islunch = menuInfoVM.Islunch,
            Pricebreak_fast = menuInfoVM.Pricebreak_fast *menuInfoVM.Countbreak_fast,

            Pricedinner = menuInfoVM.Pricedinner*menuInfoVM.Countlunch,
            Pricelunch= menuInfoVM.Pricelunch*menuInfoVM.Countdinner,

             FoodBill = menuInfoVM.Pricebreak_fast *menuInfoVM.Countbreak_fast+menuInfoVM.Pricedinner*menuInfoVM.Countlunch+ menuInfoVM.Pricelunch*menuInfoVM.Countdinner,

            };
            hotelDBContext.Add(mealInfo);
            hotelDBContext.SaveChanges();
            CheckFoodMenue.ReserveFoodID =mealInfo.ID;
        }
    }
}
