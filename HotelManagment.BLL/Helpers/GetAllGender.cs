using HotelManagment.DAL.Entities.GuestInfo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Helpers
{
    public static class GetAllGender
    {
        public static List<Gender > Getgenders()
        {
            List<Gender> genders = new List<Gender>();
            genders.Add(Gender.Male);
            genders.Add(Gender.Female);
            genders.Add(Gender.Other);
            return genders;
        }
    }
}
