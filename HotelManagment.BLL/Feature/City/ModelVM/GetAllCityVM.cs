using HotelManagment.DAL.Entities.Adress;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelManagment.BLL.Feature.City.ModelVM
{
    public class GetAllCityVM
    {
        [Key]
        public int ID { get; set; }
        public string CityName { get; set; }
        //Navigation Property

        public int StateID { get; set; }
        [ForeignKey(nameof(StateID))]
        public HotelManagment.DAL.Entities.Adress.State state { get; set; }
        public List<HotelManagment.DAL.Entities.Adress.Streets>? Streets { get; set; }
    }
}
