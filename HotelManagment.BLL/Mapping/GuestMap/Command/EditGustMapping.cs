using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.DAL.Entities.GuestInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Mapping.GuestMap.Command
{
    public static class EditGustMapping
    {
        public static Guest Map(EditGuestVM EditGuestVM)
        {
            Guest guest = new Guest()
            {
                Id = EditGuestVM.Id,
                First_name = EditGuestVM.First_name,
                Last_name = EditGuestVM.Last_name,
                Birth_day = EditGuestVM.Birth_day,
                CreditCared = EditGuestVM.CreditCared,
                email_address = EditGuestVM.email_address,
                Gender = EditGuestVM.Gender,
                Phone_number = EditGuestVM.Phone_number,
                StreetID = EditGuestVM.StreetID


            };
            return guest;
        }
    }
}
