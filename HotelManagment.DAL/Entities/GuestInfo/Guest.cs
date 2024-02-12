using HotelManagment.DAL.Entities.Adress;
using HotelManagment.DAL.Entities.GuestInfo.Enum;
using HotelManagment.DAL.Entities.Reservations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagment.DAL.Entities.GuestInfo
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string First_name { get; set; }
        [MaxLength(50), Required]
        public string Last_name { get; set; }
        [MaxLength(50), Required]
        public string Birth_day { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [MaxLength(50), Required]
        public string Phone_number { get; set; }
        [MaxLength, Required]
        public string email_address { get; set; }

        //Navigation Property
        public int StreetID { get; set; }
        [ForeignKey(nameof(StreetID))]
        public Streets Streets { get; set; }

       
        public CreditCared? CreditCared { get; set; }
        public List<Resrvations> Resrvations { get; set; }

    }
}
