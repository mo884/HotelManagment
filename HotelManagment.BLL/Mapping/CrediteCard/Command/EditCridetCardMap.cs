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
    public static class EditCridetCardMap
    {
        public static CreditCared Map(EditCridetVM EditCridetVM)
        {
            CreditCared guest = new CreditCared()
            {
                ID= EditCridetVM.ID,
                card_cvc = EditCridetVM.card_cvc,
                card_exp = EditCridetVM.card_exp,
                card_number = EditCridetVM.card_number,
                GuestID = EditCridetVM.GuestID,
                card_type = EditCridetVM.card_type,
                payment_type = EditCridetVM.payment_type,


            };
            return guest;
        }
    }
}
