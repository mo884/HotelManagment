using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.RoomRep.ModelVM
{
    public class RoomVM
    {
        public string room_type { get; set; }
        [Required]
        [MaxLength(10)]
        public string room_floor { get; set; }

        public decimal Price { get; set; }
        public string room_number { get; set; }

    }
}
