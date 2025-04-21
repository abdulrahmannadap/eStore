using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTableWith20Record : Migration
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "Rating", "ShortDescription", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 12, "SoundMagic", "https://www.pexels.com/photo/black-wireless-headphones-1234567/", "Experience immersive sound with these wireless Bluetooth headphones, featuring active noise cancellation and up to 20 hours of battery life.", "Wireless Bluetooth Headphones", 59.990000000000002, new DateOnly(2025, 2, 15), 4, "High-quality wireless headphones with noise cancellation.", 150, null },
                    { 13, "FitLife", "https://www.pexels.com/photo/smart-fitness-watch-2345678/", "Stay on top of your health goals with this smart fitness watch, offering heart rate monitoring, GPS tracking, and customizable watch faces.", "Smart Fitness Watch", 129.99000000000001, new DateOnly(2025, 2, 16), 5, "Track your fitness and health metrics with this smart watch.", 200, null },
                    { 14, "ChargeUp", "https://www.pexels.com/photo/portable-power-bank-3456789/", "Keep your devices charged with this portable 10000mAh power bank, featuring dual USB ports and fast charging capabilities.", "Portable Power Bank", 25.989999999999998, new DateOnly(2025, 2, 17), 4, "Compact 10000mAh power bank for charging on the go.", 300, null },
                    { 15, "ClickPro", "https://www.pexels.com/photo/wireless-mouse-4567890/", "Enhance your productivity with this ergonomic wireless mouse, offering adjustable DPI settings and a comfortable grip for extended use.", "Wireless Mouse", 19.989999999999998, new DateOnly(2025, 2, 18), 4, "Ergonomic wireless mouse with adjustable DPI settings.", 250, null },
                    { 16, "HubMaster", "https://www.pexels.com/photo/usb-c-hub-adapter-5678901/", "Expand your device's connectivity with this USB-C hub adapter, featuring HDMI output, USB 3.0 ports, and SD card reader.", "USB-C Hub Adapter", 34.990000000000002, new DateOnly(2025, 2, 19), 4, "Multi-port USB-C hub with HDMI and USB 3.0 ports.", 180, null },
                    { 17, "ChargeEase", "https://www.pexels.com/photo/wireless-charging-pad-6789012/", "Conveniently charge your devices with this fast wireless charging pad, compatible with all Qi-enabled smartphones and accessories.", "Wireless Charging Pad", 29.989999999999998, new DateOnly(2025, 2, 20), 4, "Fast wireless charging pad compatible with Qi-enabled devices.", 220, null },
                    { 18, "SoundBuds", "https://www.pexels.com/photo/noise-canceling-earbuds-7890123/", "Enjoy your music without distractions with these in-ear noise-canceling earbuds, delivering high-fidelity sound and a comfortable fit.", "Noise-Canceling Earbuds", 79.989999999999995, new DateOnly(2025, 2, 21), 5, "In-ear noise-canceling earbuds with high-fidelity sound.", 170, null },
                    { 19, "VisionTech", "https://www.pexels.com/photo/4k-ultra-hd-monitor-8901234/", "Upgrade your viewing experience with this 27-inch 4K Ultra HD monitor, featuring HDR support and multiple connectivity options.", "4K Ultra HD Monitor", 399.99000000000001, new DateOnly(2025, 2, 22), 5, "27-inch 4K Ultra HD monitor with HDR support.", 80, null },
                    { 20, "GameMaster", "https://www.pexels.com/photo/mechanical-gaming-keyboard-9012345/", "Enhance your gaming setup with this RGB backlit mechanical keyboard, offering customizable keys and durable switches for responsive gameplay.", "Mechanical Gaming Keyboard", 89.989999999999995, new DateOnly(2025, 2, 23), 5, "RGB backlit mechanical keyboard with customizable keys.", 130, null },
                    { 21, "DataVault", "https://www.pexels.com/photo/external-ssd-9123456/", "Store and access your data quickly with this portable 1TB external SSD, featuring high-speed USB-C connectivity and shock resistance.", "External Solid State Drive", 129.99000000000001, new DateOnly(2025, 2, 24), 5, "Portable 1TB external SSD with high-speed data transfer.", 140, null },
                    { 22, "BrightEase", "https://www.pexels.com/photo/smart-led-desk-lamp-9234567/", "Improve your workspace with this smart LED desk lamp, featuring adjustable brightness, color temperature settings, and touch controls.", "Smart LED Desk Lamp", 39.990000000000002, new DateOnly(2025, 2, 25), 4, "Adjustable LED desk lamp with touch controls.", 200, null },
                    { 23, "SecureCam", "https://www.pexels.com/photo/smart-home-security-camera-9345678/", "Keep your home safe with this smart security camera, offering 1080p resolution, motion detection, and night vision capabilities.", "Smart Home Security Camera", 89.989999999999995, new DateOnly(2025, 2, 26), 4, "Wi-Fi enabled smart security camera with night vision.", 120, null },
                    { 24, "GamePro", "https://www.pexels.com/photo/gaming-mouse-pad-9456789/", "Upgrade your gaming setup with this large RGB gaming mouse pad, featuring customizable lighting effects and an anti-slip rubber base.", "Gaming Mouse Pad", 29.989999999999998, new DateOnly(2025, 2, 27), 4, "Large RGB gaming mouse pad with anti-slip rubber base.", 160, null },
                    { 25, "OralCare", "https://www.pexels.com/photo/electric-toothbrush-9567890/", "Maintain your oral hygiene with this rechargeable electric toothbrush, offering multiple brushing modes and long battery life.", "Electric Toothbrush", 49.990000000000002, new DateOnly(2025, 2, 28), 5, "Rechargeable electric toothbrush with multiple modes.", 180, null },
                    { 26, "Memoria", "https://www.pexels.com/photo/smart-digital-photo-frame-9678901/", "Display your favorite memories with this smart digital photo frame, featuring cloud storage, slideshow modes, and touch screen controls.", "Smart Digital Photo Frame", 99.989999999999995, new DateOnly(2025, 3, 1), 5, "Wi-Fi enabled digital photo frame with cloud storage support.", 90, null },
                    { 27, "ThermoSmart", "https://www.pexels.com/photo/smart-thermos-bottle-9789012/", "Keep your beverages at the perfect temperature with this smart thermos bottle, featuring an LED temperature display and stainless steel insulation.", "Smart Thermos Bottle", 34.990000000000002, new DateOnly(2025, 3, 2), 4, "Temperature-sensing smart thermos bottle with LED display.", 150, null },
                    { 28, "VisionMini", "https://www.pexels.com/photo/mini-portable-projector-9890123/", "Enjoy a cinematic experience anywhere with this mini portable projector, featuring 1080p HD resolution, built-in speakers, and multiple input options.", "Mini Portable Projector", 149.99000000000001, new DateOnly(2025, 3, 3), 5, "Compact mini projector with 1080p HD resolution.", 80, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "ImageURL", "LongDescription", "Name", "Price", "PublishDate", "Rating", "ShortDescription", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Logitech", "", "A comfortable and precise wireless mouse with long battery life.", "Wireless Mouse", 25.0, new DateOnly(2024, 1, 15), 0, "Ergonomic wireless mouse", 100, null },
                    { 2, "Corsair", "", "High-quality mechanical keyboard with customizable RGB lighting.", "Mechanical Keyboard", 79.0, new DateOnly(2024, 2, 20), 0, "RGB mechanical keyboard", 50, null },
                    { 3, "Razer", "", "Noise-canceling gaming headset with high-fidelity surround sound and a detachable microphone.", "Gaming Headset", 60.0, new DateOnly(2023, 1, 25), 0, "Surround sound gaming headset", 75, null }
                });
        }
    }
}
