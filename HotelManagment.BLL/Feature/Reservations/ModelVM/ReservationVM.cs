using HotelManagment.DAL.Entities.GuestInfo;
using HotelManagment.DAL.Entities.Reservations.Services;
using HotelManagment.DAL.Entities.RoomInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Reservations.ModelVM
{
    public class ReservationVM
    {
        public int ID { get; set; }

        public DateTime arrival_time { get; set; }
        public DateTime leaving_time { get; set; }
        public bool check_in { get; set; }

        public int GuestID { get; set; }
        public int RoomID { get; set; }
        public int HousekeepingID { get; set; }
        public int MealInfoID { get; set; }
        [ForeignKey("GuestID")]
        public HotelManagment.DAL.Entities.GuestInfo.Guest Guest { get; set; }
        [ForeignKey("RoomID")]

        public Room Room { get; set; }
        [ForeignKey("HousekeepingID")]

        public Housekeeping Housekeeping { get; set; }
        [ForeignKey("MealInfoID")]

        public MealInfo MealInfo { get; set; }
    }
}
