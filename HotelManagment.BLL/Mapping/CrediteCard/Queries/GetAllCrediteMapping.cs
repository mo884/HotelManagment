using HotelManagment.BLL.Feature.CreditCard.ModelVM;
using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.DAL.Entities.GuestInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Mapping.CrediteCard.Queries
{
    public static class GetAllCrediteMapping
    {
        public static List<GetAllCridetVM> Map(List<CreditCared> creditCareds)
        {
            List<GetAllCridetVM> vmList = new List<GetAllCridetVM>();
            try
            {
                foreach (var item in creditCareds)
                {
                    vmList.Add(MapIndividal(item));

                }
            }
            catch (Exception)
            {


            }

            return vmList;

        }
        private static GetAllCridetVM MapIndividal(CreditCared addGuestVM)
        {
            GetAllCridetVM guest = new GetAllCridetVM()
            {
                ID= addGuestVM.ID,
                card_cvc = addGuestVM.card_cvc,
                card_exp = addGuestVM.card_exp,
                card_number = addGuestVM.card_number,
                GuestID = addGuestVM.GuestID,
                card_type = addGuestVM.card_type,
                payment_type = addGuestVM.payment_type,
                GuestName = addGuestVM.Guest.First_name+" "+addGuestVM.Guest.Last_name

            };
            return guest;
        }
    }
}
