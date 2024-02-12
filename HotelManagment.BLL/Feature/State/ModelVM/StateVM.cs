using HotelManagment.DAL.Entities.Adress;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.State.ModelVM
{
    public class StateVM
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(10), Required]
        public string ZIbCode { get; set; }
        [MaxLength(50), Required]
        public string StateName { get; set; }
        //Navigation Property

    }
}
