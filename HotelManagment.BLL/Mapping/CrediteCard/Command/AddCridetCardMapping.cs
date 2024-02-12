using HotelManagment.BLL.Feature.CreditCard.ModelVM;
using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.DAL.Entities.GuestInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Mapping.CrediteCard.Command
{
    public static class AddCridetCardMapping
    {
        public static CreditCared Map(AddCridetVM addCridetVM)
        {
            CreditCared CreditCared = new CreditCared()
            {
                card_cvc = addCridetVM.card_cvc,
                card_exp = addCridetVM.card_exp,
                card_number = addCridetVM.card_number,
                GuestID = addCridetVM.GuestID,
                card_type = addCridetVM.card_type,
                payment_type = addCridetVM.payment_type,
               


            };
            return CreditCared;
        }
    }
}
