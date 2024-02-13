using HotelManagment.DAL.Entities.RoomInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.RoomRep.ModelVM
{
    public class GetAllRoomVM
    {
        
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        public string room_number { get; set; }
        public int RoomTypeID { get; set; }
        [ForeignKey(nameof(RoomTypeID))]
        public RoomType RoomType { get; set; }
    }
}
