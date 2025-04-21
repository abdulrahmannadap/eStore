using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 27));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 28));

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
                value: new DateOnly(2025, 3, 1));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 2));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 2));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 1));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 27));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "ImageURL", "LongDescription", "Name", "OrderStage", "Price", "PublishDate", "Rating", "ShortDescription", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 401, "Apple", "Smart watch", "https://www.apple.com/newsroom/images/2023/09/apple-introduces-the-advanced-new-apple-watch-series-9/article/Apple-Watch-S9-hero-230912_Full-Bleed-Image.jpg.large.jpg", "The Apple Watch Series 9 features a brighter Always-On Retina display, a powerful S9 chip, and advanced health tracking, including ECG and blood oxygen monitoring. Seamlessly integrates with iOS devices.", "Apple Watch Series 9", "", 41999.0, new DateOnly(2025, 2, 25), 0, "Apple’s latest smartwatch with advanced health and fitness tracking.", 18, null },
                    { 402, "Samsung", "Smart watch", "https://image-us.samsung.com/us/watches/galaxy-watch6-classic/images/galaxy-watch6-classic-kv-pc.jpg", "The Galaxy Watch 6 Classic boasts a rotating bezel, Super AMOLED display, and powerful Exynos W930 processor. It offers advanced sleep tracking, body composition analysis, and seamless connectivity with Galaxy devices.", "Samsung Galaxy Watch 6 Classic", "", 39999.0, new DateOnly(2025, 3, 1), 0, "A premium smartwatch with a classic design and advanced health features.", 14, null },
                    { 403, "Garmin", "Smart watch", "https://os-wordpress-media.s3.ap-south-1.amazonaws.com/blog/wp-content/uploads/2022/01/18235651/Garmin-Fenix-7-Cover.jpg", "The Garmin Fenix 7 is a rugged smartwatch designed for adventurers, featuring GPS navigation, solar charging, heart rate monitoring, and multiple sports tracking modes for outdoor enthusiasts.", "Garmin Fenix 7", "", 69999.0, new DateOnly(2025, 2, 27), 0, "A durable GPS smartwatch for extreme outdoor adventures.", 7, null },
                    { 404, "Fitbit", "Smart watch", "https://imageio.forbes.com/specials-images/imageserve/630c7317962396f5657ec5a1/0x0.jpg?format=jpg&height=900&width=1600&fit=bounds", "The Fitbit Sense 2 is a health-focused smartwatch with an ECG app, stress management tools, and an improved sensor suite for sleep tracking, making it an excellent choice for wellness enthusiasts.", "Fitbit Sense 2", "", 25999.0, new DateOnly(2025, 3, 2), 0, "A health-centric smartwatch with stress and heart monitoring.", 20, null },
                    { 405, "Amazfit", "Smart watch", "https://us.amazfit.com/cdn/shop/products/PP-_-1_600x600.png?v=1663834312", "The Amazfit GTR 4 features a stunning AMOLED display, built-in GPS, and an advanced BioTracker sensor for heart rate and SpO2 monitoring. Offers up to 14 days of battery life on a single charge.", "Amazfit GTR 4", "", 16999.0, new DateOnly(2025, 2, 27), 0, "A stylish and long-lasting smartwatch with fitness tracking.", 25, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 1));

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 27));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 26));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 2));
        }
    }
}
