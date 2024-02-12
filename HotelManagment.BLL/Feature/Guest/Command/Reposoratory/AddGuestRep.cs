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
    public class AddGuestRep : IAddGuestRep
    {
       private readonly HotelDBContext HotelDBContext;
        public AddGuestRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Add(AddGuestVM addGuestVM)
        {
			try
			{
				var Guest = AddGustMapping.Map(addGuestVM);
                HotelDBContext.Add(Guest);
                HotelDBContext.SaveChanges();

            }
			catch (Exception)
			{

				throw;
			}
        }
    }
}
