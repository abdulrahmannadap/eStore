using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Brand", "LongDescription", "Name", "Price", "PublishDate", "ShortDescription", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Logitech", "A comfortable and precise wireless mouse with long battery life.", "Wireless Mouse", 25.0, new DateOnly(2024, 1, 15), "Ergonomic wireless mouse", 100, null },
                    { 2, "Corsair", "High-quality mechanical keyboard with customizable RGB lighting.", "Mechanical Keyboard", 79.0, new DateOnly(2024, 2, 20), "RGB mechanical keyboard", 50, null },
                    { 3, "Razer", "Noise-canceling gaming headset with high-fidelity surround sound and a detachable microphone.", "Gaming Headset", 60.0, new DateOnly(2023, 1, 25), "Surround sound gaming headset", 75, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
