using HotelManagment.DAL.Entities.Reservations.Foods.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.DAL.Entities.Reservations.Services
{
    public class DailyDiningBundle
    {
        [Key]
        public int? ID { get; set; }
        public DailyDiningBundleType? Type { get; set; }
        public decimal? Price { get; set; }

        [ForeignKey("MealInfo")]
        public int? MealInfoID { get; set; }
        
        public MealInfo? MealInfo { get; set; }
    }
}
