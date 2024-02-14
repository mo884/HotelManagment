using HotelManagment.DAL.Entities.GuestInfo.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.OverView.ModelVM
{
    public class ReservationGrid
    {
        public string room_type { get; set; }
        [Required]
        [MaxLength(10)]
        public string room_floor { get; set; }

        public decimal? Price { get; set; }
        public int RoomTypeID { get; set; }
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
        public decimal Countlunch { get; set; }
        public decimal Countbreak_fast { get; set; }
        public decimal Countdinner { get; set; }
        public decimal? FoodBill { get; set; }

    }
}
