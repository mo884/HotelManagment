using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.DAL.Entities.Adress
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        public string CityName { get; set; }
        //Navigation Property

        public int StateID { get; set; }
        [ForeignKey(nameof(StateID))]
        public State State { get; set; }
        public List<Streets> Streets { get; set; }
    }
}
