using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoriesAmdUsersTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Bebidas" },
                    { 2, 2, "Cervezas" },
                    { 3, 3, "Licores" },
                    { 4, 4, "Vinos" },
                    { 5, 5, "Comidas" },
                    { 6, 6, "Postres" },
                    { 7, 7, "Snacks" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "LastLogin", "Name", "PIN", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 17, 8, 37, 25, 95, DateTimeKind.Local).AddTicks(9708), new DateTime(2025, 4, 17, 8, 37, 25, 97, DateTimeKind.Local).AddTicks(8961), "Admin", 1234, 1 },
                    { 2, new DateTime(2025, 4, 17, 8, 37, 25, 97, DateTimeKind.Local).AddTicks(9379), new DateTime(2025, 4, 17, 8, 37, 25, 97, DateTimeKind.Local).AddTicks(9382), "User", 5678, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
