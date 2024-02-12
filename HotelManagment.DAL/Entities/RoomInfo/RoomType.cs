using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.DAL.Entities.RoomInfo
{
    public class RoomType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(10)]
        public string room_type { get; set; }
        [Required]
        [MaxLength(10)]
        public string room_floor { get; set; }

        public decimal Price { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
