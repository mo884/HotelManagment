using HotelManagment.DAL.Entities.Adress;
using HotelManagment.DAL.Entities.Identity.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.DAL.Entities.Identity
{
    public class UserIdentity
    {
        [Key]
        public int ID { get; set; }
        [Required,MaxLength(50)]
        public string UserName { get; set; }
        [Required, MaxLength(50)]
        public string Passward { get; set; }
        public IdentityType Type { get; set; }
      
    }
}
