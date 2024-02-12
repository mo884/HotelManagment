using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.DAL.Entities.GuestInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Mapping.GuestMap.Queries
{
    public static class GetAllGuestMapping
    {
        public static List<GetAllGuestVM> Map(List<Guest> Guests)
        {
            List<GetAllGuestVM> vmList = new List<GetAllGuestVM>();
            try
            {
                foreach (var item in Guests)
                {
                    vmList.Add(MapIndividal(item));

                }
            }
            catch (Exception)
            {

              
            }
            
            return vmList;

        }
        private static GetAllGuestVM MapIndividal(Guest addGuestVM)
        {
            GetAllGuestVM guest = new GetAllGuestVM()
            {
                First_name = addGuestVM.First_name,
                Last_name = addGuestVM.Last_name,
                Birth_day = addGuestVM.Birth_day,
                CreditCared = addGuestVM.CreditCared,
                email_address = addGuestVM.email_address,
                Gender = addGuestVM.Gender,
                Phone_number = addGuestVM.Phone_number,
                StreetID = addGuestVM.StreetID,
                Id = addGuestVM.Id,
                StreetName = addGuestVM.Streets.Street_Adress


            };
            return guest;
        }
    }
}
