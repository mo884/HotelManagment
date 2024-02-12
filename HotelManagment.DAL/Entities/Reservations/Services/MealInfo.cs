using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.DAL.Entities.Reservations.Services
{
    public class MealInfo
    {
        [Key]
        public int ID { get; set; }
        public decimal? FoodBill { get; set; }
        [Required]
        public List<DailyDiningBundle> DailyDiningBundle { get; set; }
        public List<Resrvations> Resrvations { get; set; }

    }
}
