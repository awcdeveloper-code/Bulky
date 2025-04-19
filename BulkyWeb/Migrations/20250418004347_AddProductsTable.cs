using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    SubCategory = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrentStock = table.Column<int>(type: "int", nullable: false),
                    ReorderLevel = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CurrentStock", "Name", "ReorderLevel", "Status", "SubCategory", "UnitCost", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 100, "COCA-COLA", 10, 1, 0, 1.50m, 2.00m },
                    { 2, 1, 100, "GINGER ALE", 10, 1, 0, 1.50m, 2.00m },
                    { 3, 1, 100, "SODA", 10, 1, 0, 1.50m, 2.00m },
                    { 4, 2, 100, "IMPERIAL REG", 10, 1, 0, 1.50m, 2.00m },
                    { 5, 2, 100, "IMPERIAL LIGHT", 10, 1, 0, 1.50m, 2.00m },
                    { 6, 2, 100, "IMPERIAL ULTRA", 10, 1, 0, 1.50m, 2.00m }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastLogin" },
                values: new object[] { new DateTime(2025, 4, 17, 18, 43, 46, 464, DateTimeKind.Local).AddTicks(4873), new DateTime(2025, 4, 17, 18, 43, 46, 466, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastLogin" },
                values: new object[] { new DateTime(2025, 4, 17, 18, 43, 46, 466, DateTimeKind.Local).AddTicks(3249), new DateTime(2025, 4, 17, 18, 43, 46, 466, DateTimeKind.Local).AddTicks(3252) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastLogin" },
                values: new object[] { new DateTime(2025, 4, 17, 8, 37, 25, 95, DateTimeKind.Local).AddTicks(9708), new DateTime(2025, 4, 17, 8, 37, 25, 97, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastLogin" },
                values: new object[] { new DateTime(2025, 4, 17, 8, 37, 25, 97, DateTimeKind.Local).AddTicks(9379), new DateTime(2025, 4, 17, 8, 37, 25, 97, DateTimeKind.Local).AddTicks(9382) });
        }
    }
}
