using HotelManagment.BLL.Feature.Guest.Command.InterFace;
using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.BLL.Mapping.GuestMap.Command;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.Adress;
using HotelManagment.DAL.Entities.GuestInfo.Enum;
using HotelManagment.DAL.Entities.GuestInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Guest.Command.Reposoratory
{
    public class EditGuestRep : IEditGuestRep
    {
       
        private readonly HotelDBContext HotelDBContext;
        public EditGuestRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public void Edit(EditGuestVM editGuestVM)
        {
            try
            {
                var Data = EditGustMapping.Map(editGuestVM);
                var Guset = HotelDBContext.Guests.Where(a => a.Id== Data.Id).FirstOrDefault();

                if (Guset is not null)
                {
                    Guset.Id = Data.Id;
                    Guset.First_name = Data.First_name;
                    Guset.Last_name = Data.Last_name;
                    Guset.Birth_day = Data.Birth_day;
                    Guset.CreditCared = Data.CreditCared;
                    Guset.email_address = Data.email_address;
                    Guset.Gender = Data.Gender;
                    Guset.Phone_number = Data.Phone_number;
                    Guset.StreetID = Data.StreetID;
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
