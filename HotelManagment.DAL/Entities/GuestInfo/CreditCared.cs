using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.DAL.Entities.GuestInfo
{
    public class CreditCared
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(10)]
        public string payment_type { get; set; }
        [Required]
        [MaxLength(10)]
        public string card_type { get; set; }
        [Required]
        [MaxLength(50)]
        public string card_number { get; set; }

        [Required]
        [MaxLength(50)]
        public string card_exp { get; set; }
        [Required]
        [MaxLength(10)]
        public string card_cvc { get; set; }
        public int GuestID { get; set; }
        public Guest Guest { get; set; }

    }
}
