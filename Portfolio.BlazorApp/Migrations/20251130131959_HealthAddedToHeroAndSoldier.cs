using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class HealthAddedToHeroAndSoldier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Soldiers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "HealthByLevel",
                table: "Soldiers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HealthByLevel",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1,
                column: "HealthByLevel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 2,
                column: "HealthByLevel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Soldiers",
                keyColumn: "Id",
                keyValue: 1,
                column: "HealthByLevel",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Soldiers",
                keyColumn: "Id",
                keyValue: 2,
                column: "HealthByLevel",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HealthByLevel",
                table: "Soldiers");

            migrationBuilder.DropColumn(
                name: "HealthByLevel",
                table: "Heroes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Soldiers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
