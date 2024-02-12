using HotelManagment.BLL.Feature.CreditCard.Command.Interface;
using HotelManagment.BLL.Feature.CreditCard.ModelVM;
using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.BLL.Mapping.CrediteCard.Command;
using HotelManagment.BLL.Mapping.GuestMap.Command;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.GuestInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.CreditCard.Command.Reposoratory
{
    public class EditeCridetCardRep : IEditCridetCardRep
    {
        private readonly HotelDBContext HotelDBContext;
        public EditeCridetCardRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Edit(EditCridetVM editVM)
        {
            try
            {
                var Data = EditCridetCardMap.Map(editVM);
                var Credit = HotelDBContext.CreditCared.Where(a => a.ID== Data.ID).FirstOrDefault();

                if (Credit is not null)
                {
                    Credit.card_cvc = Data.card_cvc;
                    Credit.card_exp = Data.card_exp;
                    Credit.card_number = Data.card_number;
                    Credit.GuestID = Data.GuestID;
                    Credit.card_type = Data.card_type;
                    Credit.payment_type = Data.payment_type;
                }
                HotelDBContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
