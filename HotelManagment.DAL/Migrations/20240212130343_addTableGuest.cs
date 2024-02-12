using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addTableGuest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Birth_day = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Phone_number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email_address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guests");
        }
    }
}
