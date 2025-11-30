using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Portfolio.BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "BaseDamage", "BaseDefense", "Level", "Name" },
                values: new object[,]
                {
                    { 1, 12, 6, 5, "Arthas" },
                    { 2, 10, 8, 4, "Lyra" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Damage", "Defense", "Name" },
                values: new object[,]
                {
                    { 1, 10, 0, "Iron Sword" },
                    { 2, 8, 0, "Longbow" },
                    { 3, 12, 0, "Fire Staff" },
                    { 4, 6, 0, "Dagger" },
                    { 5, 14, 0, "War Axe" },
                    { 6, 0, 5, "Leather Armor" },
                    { 7, 0, 8, "Iron Shield" },
                    { 8, 0, 10, "Chainmail" },
                    { 9, 0, 7, "Magic Cloak" },
                    { 10, 0, 12, "Tower Shield" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Demo Player" });

            migrationBuilder.InsertData(
                table: "Soldiers",
                columns: new[] { "Id", "BaseDamage", "BaseDefense", "Level", "Name" },
                values: new object[,]
                {
                    { 1, 6, 4, 2, "Footman" },
                    { 2, 7, 3, 2, "Archer" }
                });

            migrationBuilder.InsertData(
                table: "HeroItems",
                columns: new[] { "HeroId", "ItemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 7 },
                    { 2, 2 },
                    { 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "PlayerHeroes",
                columns: new[] { "HeroId", "PlayerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "PlayerItems",
                columns: new[] { "ItemId", "PlayerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 6, 1 },
                    { 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "PlayerSoldiers",
                columns: new[] { "PlayerId", "SoldierId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HeroItems",
                keyColumns: new[] { "HeroId", "ItemId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "HeroItems",
                keyColumns: new[] { "HeroId", "ItemId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "HeroItems",
                keyColumns: new[] { "HeroId", "ItemId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "HeroItems",
                keyColumns: new[] { "HeroId", "ItemId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PlayerHeroes",
                keyColumns: new[] { "HeroId", "PlayerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerHeroes",
                keyColumns: new[] { "HeroId", "PlayerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumns: new[] { "ItemId", "PlayerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumns: new[] { "ItemId", "PlayerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumns: new[] { "ItemId", "PlayerId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerItems",
                keyColumns: new[] { "ItemId", "PlayerId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerSoldiers",
                keyColumns: new[] { "PlayerId", "SoldierId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlayerSoldiers",
                keyColumns: new[] { "PlayerId", "SoldierId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Soldiers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Soldiers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
