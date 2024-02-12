using HotelManagment.DAL.Entities.Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.DAL.Entities.RoomInfo
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
      
        [Required]
        [MaxLength(10)]
        public string room_number { get; set; }
        public int RoomTypeID { get; set; }
        [ForeignKey(nameof(RoomTypeID))]
        public RoomType RoomType { get; set; }
        public List<Resrvations> Resrvations { get; set; }

    }
}
