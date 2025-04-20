using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesAndSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    SubCategory = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    UnitCost = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    CurrentStock = table.Column<int>(type: "int", nullable: false),
                    ReorderLevel = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIN = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "LastUpdate", "Name", "Status", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 20, 11, 46, 1, 218, DateTimeKind.Local).AddTicks(9636), new DateTime(2025, 4, 20, 11, 46, 1, 218, DateTimeKind.Local).AddTicks(9933), "Memo Grillo", 1, 1 },
                    { 2, new DateTime(2025, 4, 20, 11, 46, 1, 219, DateTimeKind.Local).AddTicks(210), new DateTime(2025, 4, 20, 11, 46, 1, 219, DateTimeKind.Local).AddTicks(212), "MESA-01", 1, 2 },
                    { 3, new DateTime(2025, 4, 20, 11, 46, 1, 219, DateTimeKind.Local).AddTicks(214), new DateTime(2025, 4, 20, 11, 46, 1, 219, DateTimeKind.Local).AddTicks(215), "MESA-02", 0, 2 },
                    { 4, new DateTime(2025, 4, 20, 11, 46, 1, 219, DateTimeKind.Local).AddTicks(216), new DateTime(2025, 4, 20, 11, 46, 1, 219, DateTimeKind.Local).AddTicks(217), "MESA-03", 0, 2 },
                    { 5, new DateTime(2025, 4, 20, 11, 46, 1, 219, DateTimeKind.Local).AddTicks(218), new DateTime(2025, 4, 20, 11, 46, 1, 219, DateTimeKind.Local).AddTicks(219), "MESA-04", 0, 2 },
                    { 6, new DateTime(2025, 4, 20, 11, 46, 1, 219, DateTimeKind.Local).AddTicks(220), new DateTime(2025, 4, 20, 11, 46, 1, 219, DateTimeKind.Local).AddTicks(221), "MESA-05", 0, 2 }
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "LastLogin", "Name", "PIN", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 20, 11, 46, 1, 216, DateTimeKind.Local).AddTicks(9329), new DateTime(2025, 4, 20, 11, 46, 1, 218, DateTimeKind.Local).AddTicks(7101), "Admin", 1234, 1 },
                    { 2, new DateTime(2025, 4, 20, 11, 46, 1, 218, DateTimeKind.Local).AddTicks(7513), new DateTime(2025, 4, 20, 11, 46, 1, 218, DateTimeKind.Local).AddTicks(7516), "User", 5678, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
