﻿using HotelManagment.DAL.Entities.GuestInfo;
using HotelManagment.DAL.Entities.GuestInfo.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Guest.ModelVM
{
    public class AddGuestVM
    {
       
        [MaxLength(50), Required]
        public string First_name { get; set; }
        [MaxLength(50), Required]
        public string Last_name { get; set; }
        [MaxLength(50), Required]
        public string Birth_day { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [MaxLength(50), Required]
        public string Phone_number { get; set; }
        [MaxLength, Required]
        public string email_address { get; set; }

        //Navigation Property
        public int StreetID { get; set; }
        public CreditCared? CreditCared { get; set; }

    }
}
