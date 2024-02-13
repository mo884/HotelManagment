using HotelManagment.DAL.Entities.Adress;
using HotelManagment.DAL.Entities.GuestInfo;
using HotelManagment.DAL.Entities.Identity;
using HotelManagment.DAL.Entities.Reservations.Foods;
using HotelManagment.DAL.Entities.Reservations.Services;
using HotelManagment.DAL.Entities.RoomInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.DAL.Database
{
    public class HotelDBContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HotelMangment;Integrated Security=True;TrustServerCertificate=true");
    
        //Person And Info
        public DbSet<UserIdentity>UserIdentities { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<CreditCared> CreditCared { get; set; }
        //Adress
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Streets> Streets { get; set; }


        public DbSet<Room> Rooms { get; set; }


        public DbSet<MealInfo> MealInfos { get; set; }

        public DbSet<DailyDiningBundle> DailyDiningBundle {  get; set; }

        public DbSet<Housekeeping> Housekeeping { get; set; }

    }
}
