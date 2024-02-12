using HotelManagment.DAL.Entities.GuestInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.DAL.Entities.Adress
{
    public class Streets
    {
        [Key]
        public int ID { get; set; }
        [Required,MaxLength]
        public string Street_Adress { get; set; }
        public int CityID { get; set; }
        [ForeignKey(nameof(CityID))]
        public City City { get; set; }
        //Navigation Property

        public List<Guest> Guests { get; set; }
    }
}
