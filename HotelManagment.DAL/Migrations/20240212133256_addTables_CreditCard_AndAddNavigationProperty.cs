using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addTables_CreditCard_AndAddNavigationProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCared",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    payment_type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    card_type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    card_number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    card_exp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    card_cvc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    GuestID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCared", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CreditCared_Guests_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreditCared_GuestID",
                table: "CreditCared",
                column: "GuestID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCared");
        }
    }
}
