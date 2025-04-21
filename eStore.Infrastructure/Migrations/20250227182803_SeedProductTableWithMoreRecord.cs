using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTableWithMoreRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "ShortDescription", "Stock" },
                values: new object[] { "NVIDIA", "", "The NVIDIA GeForce RTX 4090 delivers unparalleled gaming performance with 24GB GDDR6X memory, ray tracing, and AI-powered DLSS 3.", "NVIDIA GeForce RTX 4090", 1599.99, new DateOnly(2025, 2, 27), "Flagship gaming GPU with 24GB GDDR6X memory.", 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "ShortDescription", "Stock" },
                values: new object[] { "AMD", "", "The AMD Radeon RX 7900 XTX features RDNA 3 architecture, 24GB GDDR6 memory, and advanced ray tracing for next-gen gaming performance.", "AMD Radeon RX 7900 XTX", 999.99000000000001, new DateOnly(2025, 2, 28), "Powerful RDNA 3 gaming GPU with 24GB GDDR6.", 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "Rating", "ShortDescription", "Stock" },
                values: new object[] { "NVIDIA", "", "Experience smooth 4K gaming with the NVIDIA GeForce RTX 4080 Super, featuring 16GB GDDR6X, ray tracing, and AI-driven DLSS technology.", "NVIDIA GeForce RTX 4080 Super", 1199.99, new DateOnly(2025, 2, 26), 5, "High-end gaming GPU with 16GB GDDR6X memory.", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "ShortDescription", "Stock" },
                values: new object[] { "AMD", "", "The AMD Radeon RX 7800 XT offers 16GB of GDDR6 memory, ray tracing, and FSR 3 for high-performance gaming at 1440p and beyond.", "AMD Radeon RX 7800 XT", 549.99000000000001, new DateOnly(2025, 2, 25), "Mid-range RDNA 3 gaming GPU with 16GB GDDR6.", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "Rating", "ShortDescription" },
                values: new object[] { "NVIDIA", "", "The NVIDIA GeForce RTX 4070 Ti delivers excellent performance with 12GB GDDR6X memory, DLSS 3, and real-time ray tracing capabilities.", "NVIDIA GeForce RTX 4070 Ti", 799.99000000000001, new DateOnly(2025, 2, 24), 4, "1440p and 4K gaming GPU with 12GB GDDR6X." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "Rating", "ShortDescription", "Stock" },
                values: new object[] { "", "The AMD Radeon RX 7700 XT features 12GB GDDR6, RDNA 3 technology, and high FPS performance in modern titles at 1440p resolution.", "AMD Radeon RX 7700 XT", 449.99000000000001, new DateOnly(2025, 2, 23), 4, "1440p gaming GPU with 12GB GDDR6 memory.", 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "ShortDescription", "Stock" },
                values: new object[] { "NVIDIA", "", "The NVIDIA GeForce RTX 4060 Ti is an affordable yet powerful GPU, featuring 8GB GDDR6 memory, ray tracing, and DLSS 3 for smooth gameplay.", "NVIDIA GeForce RTX 4060 Ti", 399.99000000000001, new DateOnly(2025, 2, 22), "Budget-friendly RTX GPU with 8GB GDDR6.", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "Rating", "ShortDescription", "Stock" },
                values: new object[] { "AMD", "", "The AMD Radeon RX 7600 offers 8GB GDDR6, FSR 3 support, and solid 1080p gaming performance for budget-conscious gamers.", "AMD Radeon RX 7600", 299.99000000000001, new DateOnly(2025, 2, 21), 4, "Affordable RDNA 3 gaming GPU with 8GB GDDR6.", 120 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "Rating", "ShortDescription", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 9, "NVIDIA", "", "The NVIDIA GeForce RTX 4050 offers great 1080p gaming performance with 6GB GDDR6 memory and DLSS 3.", "NVIDIA GeForce RTX 4050", 249.99000000000001, new DateOnly(2025, 2, 20), 4, "Entry-level gaming GPU with 6GB GDDR6.", 150, null },
                    { 10, "AMD", "", "The AMD Radeon RX 7500 is perfect for 1080p gaming with 6GB GDDR6 memory and RDNA 3 technology.", "AMD Radeon RX 7500", 219.99000000000001, new DateOnly(2025, 2, 19), 4, "Budget-friendly GPU with 6GB GDDR6.", 130, null },
                    { 11, "Intel", "", "The Intel Arc A770 delivers competitive 1440p gaming performance with 16GB GDDR6 and XeSS upscaling.", "Intel Arc A770", 349.99000000000001, new DateOnly(2025, 2, 18), 4, "Intel's high-end gaming GPU with 16GB GDDR6.", 80, null },
                    { 12, "Intel", "", "The Intel Arc A750 offers great 1080p and 1440p gaming with 8GB GDDR6 and Intel's XeSS upscaling.", "Intel Arc A750", 279.99000000000001, new DateOnly(2025, 2, 17), 4, "Affordable Intel gaming GPU with 8GB GDDR6.", 90, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "ShortDescription", "Stock" },
                values: new object[] { "Apple", "https://www.ldlc-pro.be/images/digiphone13mini512red.jpg", "The Apple iPhone 13 mini features a 5.4-inch Super Retina XDR display, A15 Bionic chip, and 512GB of storage, all in a compact design.", "Apple iPhone 13 mini 512GB (PRODUCT)RED", 999.99000000000001, new DateOnly(2025, 2, 15), "Compact smartphone with 512GB storage.", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "ShortDescription", "Stock" },
                values: new object[] { "NVIDIA", "https://www.bestbuy.com/images/rtx4090.jpg", "The NVIDIA GeForce RTX 4090 offers 24GB of GDDR6X memory, delivering exceptional performance for gaming and professional applications.", "NVIDIA GeForce RTX 4090 24GB GDDR6X Graphics Card", 1499.99, new DateOnly(2025, 2, 16), "High-performance graphics card for gaming and design.", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "Rating", "ShortDescription", "Stock" },
                values: new object[] { "Crucial", "https://www.cclonline.com/images/crucial8gbddr3.jpg", "The Crucial 8GB DDR3 RAM module operates at 1600MHz, providing stable and efficient performance for various computing needs.", "Crucial 8GB (1x 8GB) 1600MHz DDR3 RAM", 39.990000000000002, new DateOnly(2025, 2, 17), 4, "Reliable 8GB DDR3 RAM module.", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "ShortDescription", "Stock" },
                values: new object[] { "Seagate", "https://www.seagate.com/images/barracudaqlcssd.jpg", "The Seagate BarraCuda QLC SSD offers 1TB of storage capacity with fast read and write speeds, ideal for everyday computing and gaming.", "Seagate BarraCuda QLC SSD 1TB", 109.98999999999999, new DateOnly(2025, 2, 18), "1TB QLC SSD for high-capacity storage.", 75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "Rating", "ShortDescription" },
                values: new object[] { "Logisys", "https://www.bhphotovideo.com/images/logisys550wpsu.jpg", "The Logisys 550W PSU provides reliable power delivery for desktop computers, featuring a 120mm ball-bearing fan for efficient cooling.", "Logisys 550W Power Supply Unit (Black)", 49.990000000000002, new DateOnly(2025, 2, 19), 3, "550W power supply unit for desktop PCs." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "Rating", "ShortDescription", "Stock" },
                values: new object[] { "https://www.amd.com/images/ryzen95900x.jpg", "The AMD Ryzen 9 5900X offers 12 cores and 24 threads, delivering exceptional performance for gaming and content creation.", "AMD Ryzen 9 5900X 12-core Processor", 549.99000000000001, new DateOnly(2025, 2, 20), 5, "High-performance 12-core desktop processor.", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "ShortDescription", "Stock" },
                values: new object[] { "ASUS", "https://www.asus.com/images/rogstrixb550f.jpg", "The ASUS ROG Strix B550-F Gaming motherboard supports AMD AM4 processors, featuring PCIe 4.0, dual M.2 slots, and robust power delivery.", "ASUS ROG Strix B550-F Gaming Motherboard", 199.99000000000001, new DateOnly(2025, 2, 21), "ATX gaming motherboard with PCIe 4.0 support.", 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "Rating", "ShortDescription", "Stock" },
                values: new object[] { "Samsung", "https://www.samsung.com/images/970evoplus500gb.jpg", "The Samsung 970 EVO Plus offers 500GB of storage with exceptional read and write speeds, enhancing system performance for various applications.", "Samsung 970 EVO Plus 500GB NVMe SSD", 89.989999999999995, new DateOnly(2025, 2, 22), 5, "High-speed 500GB NVMe solid-state drive.", 80 });
        }
    }
}
