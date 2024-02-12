using HotelManagment.BLL.Feature.CreditCard.Command.Interface;
using HotelManagment.BLL.Feature.CreditCard.ModelVM;
using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.BLL.Mapping.CrediteCard.Command;
using HotelManagment.BLL.Mapping.GuestMap.Command;
using HotelManagment.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.CreditCard.Command.Reposoratory
{
    public class AddCridetCardRep: IAddCridetCardRep
    {
        private readonly HotelDBContext HotelDBContext;
        public AddCridetCardRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Add(AddCridetVM addCridetVM)
        {
            try
            {
                var Guest = AddCridetCardMapping.Map(addCridetVM);
                HotelDBContext.CreditCared.Add(Guest);
                HotelDBContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
