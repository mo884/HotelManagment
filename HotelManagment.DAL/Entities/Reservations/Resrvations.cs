

using HotelManagment.DAL.Entities.GuestInfo;
using HotelManagment.DAL.Entities.Reservations.Services;
using HotelManagment.DAL.Entities.RoomInfo;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagment.DAL.Entities.Reservations
{
    public class Resrvations
    {
        public int ID { get; set; }
       
        public DateTime arrival_time { get; set; }
        public DateTime leaving_time { get; set; }
        public bool check_in { get; set; }

        public int GuestID { get; set; }
        public int? RoomID { get; set; }
        public int HousekeepingID { get; set; }
        public int MealInfoID { get; set; }
        [ForeignKey("GuestID")]
        public Guest Guest { get; set; }
        [ForeignKey("RoomID")]

        public Room? Room { get; set; }
        [ForeignKey("HousekeepingID")]

        public Housekeeping Housekeeping { get; set; }
        [ForeignKey("MealInfoID")]

        public MealInfo MealInfo { get; set; }


    }
}
