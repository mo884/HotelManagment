using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addMealInfoTable_AndRoomtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MealInfos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Break_Fast = table.Column<int>(type: "int", nullable: false),
                    lunch = table.Column<int>(type: "int", nullable: false),
                    Dinner = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealInfos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    room_type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    room_floor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    room_number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealInfos");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
