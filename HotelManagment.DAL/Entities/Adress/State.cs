using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.DAL.Entities.Adress
{
    public class State
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(10), Required]
        public string ZIbCode { get; set; }
        [MaxLength(50), Required]
        public string StateName { get; set; }
        //Navigation Property

        public List<City> cities { get; set; }
    }
}
