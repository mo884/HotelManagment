using HotelManagment.BLL.Feature.Guest.Command.InterFace;
using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.BLL.Mapping.GuestMap.Command;
using HotelManagment.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Guest.Command.Reposoratory
{
    public class DeleteGuestRep : IDeleteGuestRep
    {
        private readonly HotelDBContext HotelDBContext;
        public DeleteGuestRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Delete(int ID)
        {
            try
            {
                var Guset = HotelDBContext.Guests.Where(a => a.Id== ID).FirstOrDefault();

                if (Guset is not null)
                {
                    HotelDBContext.Guests.Remove(Guset);
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
