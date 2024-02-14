using HotelManagment.DAL.Entities.Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.MenuInfo.ModelVM
{
    public class MenuInfoVM
    {
        [Key]
        public int ID { get; set; }
        public decimal? FoodBill { get; set; }

        public decimal Pricelunch { get; set; }

        public bool Islunch { get; set; }
        public decimal Countlunch { get; set; }

        public decimal Pricebreak_fast { get; set; }

        public bool Isbreak_fast { get; set; }
        public decimal Countbreak_fast { get; set; }

        public decimal Pricedinner { get; set; }

        public bool Isdinner { get; set; }
        public decimal Countdinner { get; set; }


        public List<Resrvations> Resrvations { get; set; }
    }
}
