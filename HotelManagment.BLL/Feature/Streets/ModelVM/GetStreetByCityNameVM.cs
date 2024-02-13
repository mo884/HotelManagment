using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Streets.ModelVM
{
    public class GetStreetByCityNameVM
    {
        public int ID { get; set; }
        [Required, MaxLength]
        public string Street_Adress { get; set; }
        public int CityID { get; set; }
        [ForeignKey(nameof(CityID))]
        public HotelManagment.DAL.Entities.Adress.City City { get; set; }
    }
}
