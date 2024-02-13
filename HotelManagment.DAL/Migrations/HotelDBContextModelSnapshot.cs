﻿// <auto-generated />
using System;
using HotelManagment.DAL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelManagment.DAL.Migrations
{
    [DbContext(typeof(HotelDBContext))]
    partial class HotelDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelManagment.DAL.Entities.Adress.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StateID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Adress.State", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ZIbCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("State");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Adress.Streets", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("Street_Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.GuestInfo.CreditCared", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("GuestID")
                        .HasColumnType("int");

                    b.Property<string>("card_cvc")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("card_exp")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("card_number")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("card_type")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("payment_type")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("GuestID")
                        .IsUnique();

                    b.ToTable("CreditCared");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.GuestInfo.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Birth_day")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone_number")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StreetID")
                        .HasColumnType("int");

                    b.Property<string>("email_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StreetID");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Identity.UserIdentity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Passward")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("UserIdentities");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Reservations.Resrvations", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("GuestID")
                        .HasColumnType("int");

                    b.Property<int>("HousekeepingID")
                        .HasColumnType("int");

                    b.Property<int>("MealInfoID")
                        .HasColumnType("int");

                    b.Property<int?>("RoomID")
                        .HasColumnType("int");

                    b.Property<DateTime>("arrival_time")
                        .HasColumnType("datetime2");

                    b.Property<bool>("check_in")
                        .HasColumnType("bit");

                    b.Property<DateTime>("leaving_time")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("GuestID");

                    b.HasIndex("HousekeepingID");

                    b.HasIndex("MealInfoID");

                    b.HasIndex("RoomID");

                    b.ToTable("Resrvations");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Reservations.Services.DailyDiningBundle", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID"));

                    b.Property<int?>("MealInfoID")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MealInfoID");

                    b.ToTable("DailyDiningBundle");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Reservations.Services.Housekeeping", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("cleaning")
                        .HasColumnType("bit");

                    b.Property<bool>("s_surprise")
                        .HasColumnType("bit");

                    b.Property<bool>("towel")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Housekeeping");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Reservations.Services.MealInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal?>("FoodBill")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("MealInfos");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.RoomInfo.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("RoomTypeID")
                        .HasColumnType("int");

                    b.Property<string>("room_number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.RoomInfo.RoomType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("room_floor")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("room_type")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("RoomType");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Adress.City", b =>
                {
                    b.HasOne("HotelManagment.DAL.Entities.Adress.State", "State")
                        .WithMany("cities")
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Adress.Streets", b =>
                {
                    b.HasOne("HotelManagment.DAL.Entities.Adress.City", "City")
                        .WithMany("Streets")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.GuestInfo.CreditCared", b =>
                {
                    b.HasOne("HotelManagment.DAL.Entities.GuestInfo.Guest", "Guest")
                        .WithOne("CreditCared")
                        .HasForeignKey("HotelManagment.DAL.Entities.GuestInfo.CreditCared", "GuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.GuestInfo.Guest", b =>
                {
                    b.HasOne("HotelManagment.DAL.Entities.Adress.Streets", "Streets")
                        .WithMany("Guests")
                        .HasForeignKey("StreetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Streets");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Reservations.Resrvations", b =>
                {
                    b.HasOne("HotelManagment.DAL.Entities.GuestInfo.Guest", "Guest")
                        .WithMany("Resrvations")
                        .HasForeignKey("GuestID");

                    b.HasOne("HotelManagment.DAL.Entities.Reservations.Services.Housekeeping", "Housekeeping")
                        .WithMany("Resrvations")
                        .HasForeignKey("HousekeepingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelManagment.DAL.Entities.Reservations.Services.MealInfo", "MealInfo")
                        .WithMany("Resrvations")
                        .HasForeignKey("MealInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelManagment.DAL.Entities.RoomInfo.Room", "Room")
                        .WithMany("Resrvations")
                        .HasForeignKey("RoomID");

                    b.Navigation("Guest");

                    b.Navigation("Housekeeping");

                    b.Navigation("MealInfo");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Reservations.Services.DailyDiningBundle", b =>
                {
                    b.HasOne("HotelManagment.DAL.Entities.Reservations.Services.MealInfo", "MealInfo")
                        .WithMany("DailyDiningBundle")
                        .HasForeignKey("MealInfoID");

                    b.Navigation("MealInfo");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.RoomInfo.Room", b =>
                {
                    b.HasOne("HotelManagment.DAL.Entities.RoomInfo.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Adress.City", b =>
                {
                    b.Navigation("Streets");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Adress.State", b =>
                {
                    b.Navigation("cities");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Adress.Streets", b =>
                {
                    b.Navigation("Guests");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.GuestInfo.Guest", b =>
                {
                    b.Navigation("CreditCared");

                    b.Navigation("Resrvations");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Reservations.Services.Housekeeping", b =>
                {
                    b.Navigation("Resrvations");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.Reservations.Services.MealInfo", b =>
                {
                    b.Navigation("DailyDiningBundle");

                    b.Navigation("Resrvations");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.RoomInfo.Room", b =>
                {
                    b.Navigation("Resrvations");
                });

            modelBuilder.Entity("HotelManagment.DAL.Entities.RoomInfo.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
