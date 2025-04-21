using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 28));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 2));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 27));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 26));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 26));

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
                value: new DateOnly(2025, 2, 27));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 28));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 2));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 1));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 28));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "ImageURL", "LongDescription", "Name", "OrderStage", "Price", "PublishDate", "Rating", "ShortDescription", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 501, "Alienware", "Pre build", "https://os-wordpress-media.s3.ap-south-1.amazonaws.com/blog/wp-content/uploads/2022/09/29112344/Dell-Alienware-Aurora-R15.jpg", "The Alienware Aurora R15 is a high-performance gaming desktop powered by the Intel Core i9-13900KF processor and NVIDIA GeForce RTX 4090. It features advanced cooling, customizable RGB lighting, and premium build quality.", "Alienware Aurora R15", "", 389999.0, new DateOnly(2025, 3, 2), 5, "A powerful gaming PC with top-tier specs and premium cooling.", 5, null },
                    { 502, "Asus", "Pre build", "https://m.media-amazon.com/images/I/71WChkpECLL.jpg", "The Asus ROG Strix G16 gaming PC comes with an Intel Core i7-13700KF processor, NVIDIA RTX 4070 Ti GPU, 32GB DDR5 RAM, and a 1TB NVMe SSD. Perfect for high-FPS gaming and content creation.", "Asus ROG Strix G16", "", 229999.0, new DateOnly(2025, 2, 27), 4, "A high-performance gaming PC with an RTX 4070 Ti and powerful cooling.", 8, null },
                    { 503, "HP", "Pre build", "https://kaas.hpcloud.hp.com/PROD/v2/renderbinary/7573403/5038347/con-win-dt-p-omen-45l-gt22-1015nl-product-specifications/articuno-desktop", "The HP Omen 45L gaming desktop features an AMD Ryzen 9 7900X, NVIDIA RTX 4080, 32GB DDR5 RAM, and a unique Cryo Chamber cooling system for extreme performance and efficiency.", "HP Omen 45L", "", 269999.0, new DateOnly(2025, 2, 25), 5, "A premium gaming PC with advanced cooling and powerful hardware.", 6, null },
                    { 504, "MSI", "Pre build", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQMAbfTV4NnUxIDwvzYDthWyZ78yTVZ8uASjw&s", "The MSI Infinite RS 14th gaming PC packs an Intel Core i9-14900KF, NVIDIA RTX 4090, 64GB DDR5 RAM, and a 2TB NVMe SSD, offering ultimate gaming performance and seamless multitasking.", "MSI Infinite RS 14th", "", 399999.0, new DateOnly(2025, 2, 28), 2, "A beastly gaming PC with the latest Intel and NVIDIA technology.", 4, null },
                    { 505, "CyberPowerPC", "Pre build", "https://m.media-amazon.com/images/I/71itNiAeHEL.jpg", "CyberPowerPC Gamer Supreme is an affordable yet powerful gaming PC with an AMD Ryzen 7 7700X, RTX 4060 Ti, 16GB DDR5 RAM, and a 1TB SSD, offering smooth gaming performance for all modern titles.", "CyberPowerPC Gamer Supreme", "", 149999.0, new DateOnly(2025, 2, 25), 3, "A budget-friendly gaming PC with excellent performance.", 12, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 28));

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
                keyValue: 401,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 25));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402,
                column: "PublishDate",
                value: new DateOnly(2025, 3, 1));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 27));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405,
                column: "PublishDate",
                value: new DateOnly(2025, 2, 27));
        }
    }
}
