using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addtablesService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "room_floor",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "room_type",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Break_Fast",
                table: "MealInfos");

            migrationBuilder.DropColumn(
                name: "Dinner",
                table: "MealInfos");

            migrationBuilder.DropColumn(
                name: "lunch",
                table: "MealInfos");

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeID",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "FoodBill",
                table: "MealInfos",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DailyDiningBundle",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MealInfoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyDiningBundle", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DailyDiningBundle_MealInfos_MealInfoID",
                        column: x => x.MealInfoID,
                        principalTable: "MealInfos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Housekeeping",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cleaning = table.Column<bool>(type: "bit", nullable: false),
                    towel = table.Column<bool>(type: "bit", nullable: false),
                    s_surprise = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Housekeeping", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    room_type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    room_floor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Resrvations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arrival_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    leaving_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    check_in = table.Column<bool>(type: "bit", nullable: false),
                    GuestID = table.Column<int>(type: "int", nullable: true),
                    RoomID = table.Column<int>(type: "int", nullable: true),
                    HousekeepingID = table.Column<int>(type: "int", nullable: false),
                    MealInfoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resrvations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Resrvations_Guests_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Resrvations_Housekeeping_HousekeepingID",
                        column: x => x.HousekeepingID,
                        principalTable: "Housekeeping",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resrvations_MealInfos_MealInfoID",
                        column: x => x.MealInfoID,
                        principalTable: "MealInfos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resrvations_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeID",
                table: "Rooms",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DailyDiningBundle_MealInfoID",
                table: "DailyDiningBundle",
                column: "MealInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Resrvations_GuestID",
                table: "Resrvations",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_Resrvations_HousekeepingID",
                table: "Resrvations",
                column: "HousekeepingID");

            migrationBuilder.CreateIndex(
                name: "IX_Resrvations_MealInfoID",
                table: "Resrvations",
                column: "MealInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Resrvations_RoomID",
                table: "Resrvations",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeID",
                table: "Rooms",
                column: "RoomTypeID",
                principalTable: "RoomType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeID",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "DailyDiningBundle");

            migrationBuilder.DropTable(
                name: "Resrvations");

            migrationBuilder.DropTable(
                name: "RoomType");

            migrationBuilder.DropTable(
                name: "Housekeeping");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomTypeID",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomTypeID",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "FoodBill",
                table: "MealInfos");

            migrationBuilder.AddColumn<string>(
                name: "room_floor",
                table: "Rooms",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "room_type",
                table: "Rooms",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Break_Fast",
                table: "MealInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dinner",
                table: "MealInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lunch",
                table: "MealInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
