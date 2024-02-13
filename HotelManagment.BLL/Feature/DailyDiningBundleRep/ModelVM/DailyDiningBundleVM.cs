using HotelManagment.DAL.Entities.Reservations.Foods.Enum;
using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.DailyDiningBundleRep.ModelVM
{
    public class DailyDiningBundleVM
    {
        [Key]
        public int ID { get; set; }
        public DailyDiningBundleType Type { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("MealInfo")]
        public int MealInfoID { get; set; }

        public MealInfo MealInfo { get; set; }

        public decimal Count { get; set; }
    }
}
