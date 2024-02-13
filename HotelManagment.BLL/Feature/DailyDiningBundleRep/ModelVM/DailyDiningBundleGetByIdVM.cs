using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.DailyDiningBundleRep.ModelVM
{
    public class DailyDiningBundleGetByIdVM
    {
        public int ID { get; set; }
        public decimal? FoodBill { get; set; }
        [Required]
        public List<DailyDiningBundle> DailyDiningBundle { get; set; }
    }
}
