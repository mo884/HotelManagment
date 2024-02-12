using HotelManagment.BLL.Feature.CreditCard.Command.Interface;
using HotelManagment.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.CreditCard.Command.Reposoratory
{
    internal class DeleteCridetCardRep : IDeleteCridetCardRep
    {
        private readonly HotelDBContext HotelDBContext;
        public DeleteCridetCardRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Delete(int ID)
        {
            try
            {
                var Credit = HotelDBContext.CreditCared.Where(a => a.ID== ID).FirstOrDefault();

                if (Credit is not null)
                {
                    HotelDBContext.CreditCared.Remove(Credit);
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
