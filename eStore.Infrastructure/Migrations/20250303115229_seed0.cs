using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 1));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 27));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 26));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 28));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 27));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 27));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 1));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 28));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "ImageURL", "LongDescription", "Name", "OrderStage", "Price", "PublishDate", "Rating", "ShortDescription", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 301, "Sony", "Console", "https://m.media-amazon.com/images/I/51fRDc+9ajL.jpg", "The PlayStation 5 features an ultra-high-speed SSD, ray tracing capabilities, and 4K gaming at up to 120Hz. With the powerful AMD Ryzen Zen 2 processor and RDNA 2 GPU, it delivers an immersive gaming experience.", "Sony PlayStation 5", "", 55999.0, new DateOnly(2025, 2, 27), 0, "Sony's next-gen console with ultra-fast performance and 4K gaming.", 15, null },
                    { 302, "Microsoft", "Console", "https://assets.xboxservices.com/assets/18/30/1830806b-d41d-40ce-a846-792df7d14e1d.jpg?n=Xbox-Series-X_Sharing_200x200_02.jpg", "The Xbox Series X is Microsoft’s most powerful console, featuring 12 teraflops of power, 1TB SSD storage, and support for 4K gaming at up to 120FPS, ensuring seamless and responsive gameplay.", "Microsoft Xbox Series X", "", 52999.0, new DateOnly(2025, 2, 25), 0, "Microsoft's most powerful 4K gaming console.", 10, null },
                    { 303, "Nintendo", "Console", "https://m.media-amazon.com/images/I/61nqNujSF2L.jpg", "The Nintendo Switch OLED features a 7-inch OLED screen for vibrant colors, enhanced audio, and a sturdy adjustable stand, providing an immersive gaming experience in handheld, tabletop, or docked mode.", "Nintendo Switch OLED", "", 34999.0, new DateOnly(2025, 2, 26), 0, "Nintendo's hybrid console with an upgraded OLED display.", 12, null },
                    { 304, "Sony", "Console", "https://rukminim2.flixcart.com/image/850/1000/xif0q/gamingconsole/z/b/w/-original-imagtk7vfbzqbjg6.jpeg?q=90&crop=false", "The PS5 Digital Edition offers the same powerful performance as the standard PS5 but without a disc drive, making it perfect for digital game libraries and cloud gaming enthusiasts.", "Sony PlayStation 5 Digital Edition", "", 45999.0, new DateOnly(2025, 2, 25), 0, "A digital-only version of the PlayStation 5.", 8, null },
                    { 305, "Microsoft", "Console", "https://www.designinfo.in/wp-content/uploads/2023/01/xbox-series-s-3-game-combo-2-485x485-optimized.jpg", "The Xbox Series S is a compact and affordable next-gen console that delivers smooth 1440p gaming at up to 120FPS, powered by an advanced SSD for ultra-fast load times.", "Microsoft Xbox Series S", "", 34999.0, new DateOnly(2025, 3, 2), 0, "A budget-friendly next-gen Xbox console with fast performance.", 14, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 2));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 28));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 2));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 27));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 26));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 26));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));
        }
    }
}
