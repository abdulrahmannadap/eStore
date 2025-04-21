using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "ImageURL", "LongDescription", "Name", "OrderStage", "Price", "PublishDate", "Rating", "ShortDescription", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 101, "Samsung", "Smartphones", "https://rukminim2.flixcart.com/image/850/1000/xif0q/mobile/1/x/3/-original-imah8pdnxdwzazyy.jpeg?q=20&crop=false", "The Samsung Galaxy S25 Ultra offers a 6.9-inch Dynamic AMOLED 2X display, Snapdragon 8 Elite processor, and a 200MP quad-camera system. The 5000mAh battery supports 45W fast charging for all-day use.", "Samsung Galaxy S25 Ultra", "", 129999.0, new DateOnly(2025, 3, 2), 0, "A flagship phone with a powerful camera and AI capabilities.", 10, null },
                    { 102, "Apple", "Smartphones", "https://www.imagineonline.store/cdn/shop/files/iPhone_15_Pro_Max_Blue_Titanium_PDP_Image_Position-1__en-IN.jpg?v=1694758834", "The iPhone 15 Pro Max features a titanium frame, A17 Pro chip, and a 48MP primary camera with enhanced low-light performance. A 6.7-inch Super Retina XDR display ensures stunning visuals.", "Apple iPhone 15 Pro Max", "", 159999.0, new DateOnly(2025, 2, 28), 0, "Apple's premium iPhone with an advanced camera system.", 8, null },
                    { 103, "OnePlus", "Smartphones", "https://images.jdmagicbox.com/quickquotes/images_main/12-ram-16-gb-512-gb-flowy-emerald-272751531-d2abqe4q.png", "The OnePlus 12 Pro is powered by the Snapdragon 8 Gen 3 processor, featuring a 6.8-inch 120Hz AMOLED display and a Hasselblad-tuned 64MP camera system. 100W fast charging ensures rapid power-up.", "OnePlus 12 Pro", "", 74999.0, new DateOnly(2025, 3, 2), 0, "A flagship killer with blazing-fast performance and premium design.", 15, null },
                    { 104, "Google", "Smartphones", "https://storage.googleapis.com/gweb-uniblog-publish-prod/images/Pixel_8_Pro_in_Porcelain.max-936x936.format-webp.webp", "The Google Pixel 8 Pro boasts an AI-powered Tensor G3 chip, a 50MP main camera, and exclusive Pixel software features. The 6.7-inch LTPO OLED display delivers stunning clarity.", "Google Pixel 8 Pro", "", 106999.0, new DateOnly(2025, 2, 27), 0, "The best of Google’s AI-powered smartphone experience.", 12, null },
                    { 201, "NVIDIA", "Graphic card", "https://www.nvidia.com/content/dam/en-zz/Solutions/geforce/ada/rtx-4090/geforce-ada-4090-web-og-1200x630.jpg", "The NVIDIA GeForce RTX 4090 is the most powerful gaming GPU, featuring 24GB GDDR6X memory, 16384 CUDA cores, and DLSS 3.0 for ultra-high performance in 4K gaming.", "NVIDIA GeForce RTX 4090", "", 189999.0, new DateOnly(2025, 2, 25), 0, "A flagship GPU with cutting-edge ray tracing and AI features.", 7, null },
                    { 202, "AMD", "Graphic card", "https://preview.redd.it/those-with-7900-xtx-hows-your-overclock-tuning-looking-like-v0-wibuxo51cusc1.jpeg?auto=webp&s=c9e003483c59df704342d6b434445fdc278b72e0", "The AMD Radeon RX 7900 XTX delivers top-tier gaming performance with 24GB GDDR6 memory, RDNA 3 architecture, and advanced ray tracing for smooth 4K and high-refresh gaming.", "AMD Radeon RX 7900 XTX", "", 108999.0, new DateOnly(2025, 2, 26), 0, "AMD’s flagship gaming GPU with high performance.", 9, null },
                    { 203, "NVIDIA", "Graphic card", "https://m.media-amazon.com/images/I/71-djDvKjfL.jpg", "The RTX 4070 Ti is a high-performance gaming GPU featuring 12GB GDDR6X memory, DLSS 3.0, and 7680 CUDA cores, delivering excellent 1440p and 4K gaming performance.", "NVIDIA GeForce RTX 4070 Ti", "", 79999.0, new DateOnly(2025, 2, 26), 0, "A powerful mid-high range GPU for gamers and creators.", 12, null },
                    { 204, "AMD", "Graphic card", "https://m.media-amazon.com/images/I/71GKfo5qtaL._AC_UF1000,1000_QL80_.jpg", "The RX 7800 XT is designed for high-quality 1440p gaming, featuring 16GB GDDR6 memory, RDNA 3 architecture, and AI-powered graphics enhancements.", "AMD Radeon RX 7800 XT", "", 57999.0, new DateOnly(2025, 2, 25), 0, "A great choice for high-performance 1440p gaming.", 14, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "ImageURL", "LongDescription", "Name", "OrderStage", "Price", "PublishDate", "Rating", "ShortDescription", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "NVIDIA", "", "", "The NVIDIA GeForce RTX 4090 delivers unparalleled gaming performance with 24GB GDDR6X memory, ray tracing, and AI-powered DLSS 3.", "NVIDIA GeForce RTX 4090", "", 1599.99, new DateOnly(2025, 2, 27), 5, "Flagship gaming GPU with 24GB GDDR6X memory.", 20, null },
                    { 2, "AMD", "", "", "The AMD Radeon RX 7900 XTX features RDNA 3 architecture, 24GB GDDR6 memory, and advanced ray tracing for next-gen gaming performance.", "AMD Radeon RX 7900 XTX", "", 999.99000000000001, new DateOnly(2025, 2, 28), 5, "Powerful RDNA 3 gaming GPU with 24GB GDDR6.", 35, null },
                    { 3, "NVIDIA", "", "", "Experience smooth 4K gaming with the NVIDIA GeForce RTX 4080 Super, featuring 16GB GDDR6X, ray tracing, and AI-driven DLSS technology.", "NVIDIA GeForce RTX 4080 Super", "", 1199.99, new DateOnly(2025, 2, 26), 5, "High-end gaming GPU with 16GB GDDR6X memory.", 40, null },
                    { 4, "AMD", "", "", "The AMD Radeon RX 7800 XT offers 16GB of GDDR6 memory, ray tracing, and FSR 3 for high-performance gaming at 1440p and beyond.", "AMD Radeon RX 7800 XT", "", 549.99000000000001, new DateOnly(2025, 2, 25), 4, "Mid-range RDNA 3 gaming GPU with 16GB GDDR6.", 50, null },
                    { 5, "NVIDIA", "", "", "The NVIDIA GeForce RTX 4070 Ti delivers excellent performance with 12GB GDDR6X memory, DLSS 3, and real-time ray tracing capabilities.", "NVIDIA GeForce RTX 4070 Ti", "", 799.99000000000001, new DateOnly(2025, 2, 24), 4, "1440p and 4K gaming GPU with 12GB GDDR6X.", 60, null },
                    { 6, "AMD", "", "", "The AMD Radeon RX 7700 XT features 12GB GDDR6, RDNA 3 technology, and high FPS performance in modern titles at 1440p resolution.", "AMD Radeon RX 7700 XT", "", 449.99000000000001, new DateOnly(2025, 2, 23), 4, "1440p gaming GPU with 12GB GDDR6 memory.", 70, null },
                    { 7, "NVIDIA", "", "", "The NVIDIA GeForce RTX 4060 Ti is an affordable yet powerful GPU, featuring 8GB GDDR6 memory, ray tracing, and DLSS 3 for smooth gameplay.", "NVIDIA GeForce RTX 4060 Ti", "", 399.99000000000001, new DateOnly(2025, 2, 22), 4, "Budget-friendly RTX GPU with 8GB GDDR6.", 100, null },
                    { 8, "AMD", "", "", "The AMD Radeon RX 7600 offers 8GB GDDR6, FSR 3 support, and solid 1080p gaming performance for budget-conscious gamers.", "AMD Radeon RX 7600", "", 299.99000000000001, new DateOnly(2025, 2, 21), 4, "Affordable RDNA 3 gaming GPU with 8GB GDDR6.", 120, null },
                    { 9, "NVIDIA", "", "", "The NVIDIA GeForce RTX 4050 offers great 1080p gaming performance with 6GB GDDR6 memory and DLSS 3.", "NVIDIA GeForce RTX 4050", "", 249.99000000000001, new DateOnly(2025, 2, 20), 4, "Entry-level gaming GPU with 6GB GDDR6.", 150, null },
                    { 10, "AMD", "", "", "The AMD Radeon RX 7500 is perfect for 1080p gaming with 6GB GDDR6 memory and RDNA 3 technology.", "AMD Radeon RX 7500", "", 219.99000000000001, new DateOnly(2025, 2, 19), 4, "Budget-friendly GPU with 6GB GDDR6.", 130, null },
                    { 11, "Intel", "", "", "The Intel Arc A770 delivers competitive 1440p gaming performance with 16GB GDDR6 and XeSS upscaling.", "Intel Arc A770", "", 349.99000000000001, new DateOnly(2025, 2, 18), 4, "Intel's high-end gaming GPU with 16GB GDDR6.", 80, null },
                    { 12, "Intel", "", "", "The Intel Arc A750 offers great 1080p and 1440p gaming with 8GB GDDR6 and Intel's XeSS upscaling.", "Intel Arc A750", "", 279.99000000000001, new DateOnly(2025, 2, 17), 4, "Affordable Intel gaming GPU with 8GB GDDR6.", 90, null }
                });
        }
    }
}
