using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyDiningBundle_MealInfos_MealInfoID",
                table: "DailyDiningBundle");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "DailyDiningBundle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "DailyDiningBundle",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "MealInfoID",
                table: "DailyDiningBundle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyDiningBundle_MealInfos_MealInfoID",
                table: "DailyDiningBundle",
                column: "MealInfoID",
                principalTable: "MealInfos",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyDiningBundle_MealInfos_MealInfoID",
                table: "DailyDiningBundle");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "DailyDiningBundle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "DailyDiningBundle",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MealInfoID",
                table: "DailyDiningBundle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyDiningBundle_MealInfos_MealInfoID",
                table: "DailyDiningBundle",
                column: "MealInfoID",
                principalTable: "MealInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
