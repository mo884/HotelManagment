using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.DAL.Entities.Reservations.Services
{
    public class Housekeeping
    {
        public int ID { get; set; }
        public bool cleaning { get; set; }
        public bool towel { get; set; }
        public bool s_surprise { get; set; }

        public List<Resrvations> Resrvations { get; set; }

    }
}
