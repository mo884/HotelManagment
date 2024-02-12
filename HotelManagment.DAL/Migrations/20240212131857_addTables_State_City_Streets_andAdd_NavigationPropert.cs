using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addTables_State_City_Streets_andAdd_NavigationPropert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StreetID",
                table: "Guests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZIbCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<int>(type: "int", nullable: false),
                    StateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ID);
                    table.ForeignKey(
                        name: "FK_City_State_StateID",
                        column: x => x.StateID,
                        principalTable: "State",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Streets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street_Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Streets_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guests_StreetID",
                table: "Guests",
                column: "StreetID");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateID",
                table: "City",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_Streets_CityID",
                table: "Streets",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_Streets_StreetID",
                table: "Guests",
                column: "StreetID",
                principalTable: "Streets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Streets_StreetID",
                table: "Guests");

            migrationBuilder.DropTable(
                name: "Streets");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropIndex(
                name: "IX_Guests_StreetID",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "StreetID",
                table: "Guests");
        }
    }
}
