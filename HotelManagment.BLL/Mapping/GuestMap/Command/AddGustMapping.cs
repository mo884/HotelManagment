using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.DAL.Entities.GuestInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Mapping.GuestMap.Command
{
    public static class AddGustMapping
    {
        public static Guest Map(AddGuestVM addGuestVM)
        {
            Guest guest = new Guest()
            {
                First_name = addGuestVM.First_name,
                Last_name = addGuestVM.Last_name,
                Birth_day = addGuestVM.Birth_day,
                CreditCared = addGuestVM.CreditCared,
                email_address = addGuestVM.email_address,
                Gender = addGuestVM.Gender,
                Phone_number = addGuestVM.Phone_number,
                StreetID = addGuestVM.StreetID

                
            };
            return guest;
        }
    }
}
