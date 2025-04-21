using eStore.Application.Utilities;
using eStore.Domain.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eStore.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<TargetAudience> TargetAudiences { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var rnd = new Random();
            var seedData = new List<Product>()

{
    new Product() {
        Id = 101,
        ImageURL = "https://rukminim2.flixcart.com/image/850/1000/xif0q/mobile/1/x/3/-original-imah8pdnxdwzazyy.jpeg?q=20&crop=false",
        Name = "Samsung Galaxy S25 Ultra",
        LongDescription = "The Samsung Galaxy S25 Ultra offers a 6.9-inch Dynamic AMOLED 2X display, Snapdragon 8 Elite processor, and a 200MP quad-camera system. The 5000mAh battery supports 45W fast charging for all-day use.",
        ShortDescription = "A flagship phone with a powerful camera and AI capabilities.",
        Brand = "Samsung",
        Price = 129999,
        Stock = 10,
        Category = StaticDetails.Products.Categories["Smartphones"],
         // This generates a random date between 1 and 6 days ago (excludes today and exactly 7 days ago)
         // PublishDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-new Random().Next(1, 7))),

         // This generates a random date between today (0 days ago) and 7 days ago (inclusive of both ends)
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 5
    },
    new Product() {
        Id = 102,
        ImageURL = "https://www.imagineonline.store/cdn/shop/files/iPhone_15_Pro_Max_Blue_Titanium_PDP_Image_Position-1__en-IN.jpg?v=1694758834",
        Name = "Apple iPhone 15 Pro Max",
        LongDescription = "The iPhone 15 Pro Max features a titanium frame, A17 Pro chip, and a 48MP primary camera with enhanced low-light performance. A 6.7-inch Super Retina XDR display ensures stunning visuals.",
        ShortDescription = "Apple's premium iPhone with an advanced camera system.",
        Brand = "Apple",
        Price = 159999,
        Stock = 8,
        Category = StaticDetails.Products.Categories["Smartphones"],
    PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 3
    },
    new Product() {
        Id = 103,
        ImageURL = "https://images.jdmagicbox.com/quickquotes/images_main/12-ram-16-gb-512-gb-flowy-emerald-272751531-d2abqe4q.png",
        Name = "OnePlus 12 Pro",
        LongDescription = "The OnePlus 12 Pro is powered by the Snapdragon 8 Gen 3 processor, featuring a 6.8-inch 120Hz AMOLED display and a Hasselblad-tuned 64MP camera system. 100W fast charging ensures rapid power-up.",
        ShortDescription = "A flagship killer with blazing-fast performance and premium design.",
        Brand = "OnePlus",
        Price = 74999,
        Stock = 15,
        Category = StaticDetails.Products.Categories["Smartphones"],

        Rating = 4
    },
    new Product() {
        Id = 104,
        ImageURL = "https://storage.googleapis.com/gweb-uniblog-publish-prod/images/Pixel_8_Pro_in_Porcelain.max-936x936.format-webp.webp",
        Name = "Google Pixel 8 Pro",
        LongDescription = "The Google Pixel 8 Pro boasts an AI-powered Tensor G3 chip, a 50MP main camera, and exclusive Pixel software features. The 6.7-inch LTPO OLED display delivers stunning clarity.",
        ShortDescription = "The best of Google’s AI-powered smartphone experience.",
        Brand = "Google",
        Price = 106999,
        Stock = 12,
        Category = StaticDetails.Products.Categories["Smartphones"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 1
    },
    new Product() {
        Id = 201,
        ImageURL = "https://www.nvidia.com/content/dam/en-zz/Solutions/geforce/ada/rtx-4090/geforce-ada-4090-web-og-1200x630.jpg",
        Name = "NVIDIA GeForce RTX 4090",
        LongDescription = "The NVIDIA GeForce RTX 4090 is the most powerful gaming GPU, featuring 24GB GDDR6X memory, 16384 CUDA cores, and DLSS 3.0 for ultra-high performance in 4K gaming.",
        ShortDescription = "A flagship GPU with cutting-edge ray tracing and AI features.",
        Brand = "NVIDIA",
        Price = 189999,
        Stock = 7,
        Category = StaticDetails.Products.Categories["GPU"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 5
    },
    new Product() {
        Id = 202,
        ImageURL = "https://preview.redd.it/those-with-7900-xtx-hows-your-overclock-tuning-looking-like-v0-wibuxo51cusc1.jpeg?auto=webp&s=c9e003483c59df704342d6b434445fdc278b72e0",
        Name = "AMD Radeon RX 7900 XTX",
        LongDescription = "The AMD Radeon RX 7900 XTX delivers top-tier gaming performance with 24GB GDDR6 memory, RDNA 3 architecture, and advanced ray tracing for smooth 4K and high-refresh gaming.",
        ShortDescription = "AMD’s flagship gaming GPU with high performance.",
        Brand = "AMD",
        Price = 108999,
        Stock = 9,
        Category = StaticDetails.Products.Categories["GPU"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 2
    },
    new Product() {
        Id = 203,
        ImageURL = "https://m.media-amazon.com/images/I/71-djDvKjfL.jpg",
        Name = "NVIDIA GeForce RTX 4070 Ti",
        LongDescription = "The RTX 4070 Ti is a high-performance gaming GPU featuring 12GB GDDR6X memory, DLSS 3.0, and 7680 CUDA cores, delivering excellent 1440p and 4K gaming performance.",
        ShortDescription = "A powerful mid-high range GPU for gamers and creators.",
        Brand = "NVIDIA",
        Price = 79999,
        Stock = 12,
        Category = StaticDetails.Products.Categories["GPU"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 5
    },
    new Product() {
        Id = 204,
        ImageURL = "https://m.media-amazon.com/images/I/71GKfo5qtaL._AC_UF1000,1000_QL80_.jpg",
        Name = "AMD Radeon RX 7800 XT",
        LongDescription = "The RX 7800 XT is designed for high-quality 1440p gaming, featuring 16GB GDDR6 memory, RDNA 3 architecture, and AI-powered graphics enhancements.",
        ShortDescription = "A great choice for high-performance 1440p gaming.",
        Brand = "AMD",
        Price = 57999,
        Stock = 14,
        Category = StaticDetails.Products.Categories["GPU"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 2
    },
       new Product() {
        Id = 301,
        ImageURL = "https://m.media-amazon.com/images/I/51fRDc+9ajL.jpg",
        Name = "Sony PlayStation 5",
        LongDescription = "The PlayStation 5 features an ultra-high-speed SSD, ray tracing capabilities, and 4K gaming at up to 120Hz. With the powerful AMD Ryzen Zen 2 processor and RDNA 2 GPU, it delivers an immersive gaming experience.",
        ShortDescription = "Sony's next-gen console with ultra-fast performance and 4K gaming.",
        Brand = "Sony",
        Price = 55999,
        Stock = 15,
        Category = StaticDetails.Products.Categories["Consoles"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 4
    },
    new Product() {
        Id = 302,
        ImageURL = "https://assets.xboxservices.com/assets/18/30/1830806b-d41d-40ce-a846-792df7d14e1d.jpg?n=Xbox-Series-X_Sharing_200x200_02.jpg",
        Name = "Microsoft Xbox Series X",
        LongDescription = "The Xbox Series X is Microsoft’s most powerful console, featuring 12 teraflops of power, 1TB SSD storage, and support for 4K gaming at up to 120FPS, ensuring seamless and responsive gameplay.",
        ShortDescription = "Microsoft's most powerful 4K gaming console.",
        Brand = "Microsoft",
        Price = 52999,
        Stock = 10,
        Category = StaticDetails.Products.Categories["Consoles"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 4
    },
    new Product() {
        Id = 303,
        ImageURL = "https://m.media-amazon.com/images/I/61nqNujSF2L.jpg",
        Name = "Nintendo Switch OLED",
        LongDescription = "The Nintendo Switch OLED features a 7-inch OLED screen for vibrant colors, enhanced audio, and a sturdy adjustable stand, providing an immersive gaming experience in handheld, tabletop, or docked mode.",
        ShortDescription = "Nintendo's hybrid console with an upgraded OLED display.",
        Brand = "Nintendo",
        Price = 34999,
        Stock = 12,
        Category = StaticDetails.Products.Categories["Consoles"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 4
    },
    new Product() {
        Id = 304,
        ImageURL = "https://rukminim2.flixcart.com/image/850/1000/xif0q/gamingconsole/z/b/w/-original-imagtk7vfbzqbjg6.jpeg?q=90&crop=false",
        Name = "Sony PlayStation 5 Digital Edition",
        LongDescription = "The PS5 Digital Edition offers the same powerful performance as the standard PS5 but without a disc drive, making it perfect for digital game libraries and cloud gaming enthusiasts.",
        ShortDescription = "A digital-only version of the PlayStation 5.",
        Brand = "Sony",
        Price = 45999,
        Stock = 8,
        Category = StaticDetails.Products.Categories["Consoles"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 1
    },
    new Product() {
        Id = 305,
        ImageURL = "https://www.designinfo.in/wp-content/uploads/2023/01/xbox-series-s-3-game-combo-2-485x485-optimized.jpg",
        Name = "Microsoft Xbox Series S",
        LongDescription = "The Xbox Series S is a compact and affordable next-gen console that delivers smooth 1440p gaming at up to 120FPS, powered by an advanced SSD for ultra-fast load times.",
        ShortDescription = "A budget-friendly next-gen Xbox console with fast performance.",
        Brand = "Microsoft",
        Price = 34999,
        Stock = 14,
        Category = StaticDetails.Products.Categories["Consoles"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 1
    },
    new Product() {
        Id = 401,
        ImageURL = "https://www.apple.com/newsroom/images/2023/09/apple-introduces-the-advanced-new-apple-watch-series-9/article/Apple-Watch-S9-hero-230912_Full-Bleed-Image.jpg.large.jpg",
        Name = "Apple Watch Series 9",
        LongDescription = "The Apple Watch Series 9 features a brighter Always-On Retina display, a powerful S9 chip, and advanced health tracking, including ECG and blood oxygen monitoring. Seamlessly integrates with iOS devices.",
        ShortDescription = "Apple’s latest smartwatch with advanced health and fitness tracking.",
        Brand = "Apple",
        Price = 41999,
        Stock = 18,
        Category = StaticDetails.Products.Categories["Smartwatches"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 3
    },
    new Product() {
        Id = 402,
        ImageURL = "https://image-us.samsung.com/us/watches/galaxy-watch6-classic/images/galaxy-watch6-classic-kv-pc.jpg",
        Name = "Samsung Galaxy Watch 6 Classic",
        LongDescription = "The Galaxy Watch 6 Classic boasts a rotating bezel, Super AMOLED display, and powerful Exynos W930 processor. It offers advanced sleep tracking, body composition analysis, and seamless connectivity with Galaxy devices.",
        ShortDescription = "A premium smartwatch with a classic design and advanced health features.",
        Brand = "Samsung",
        Price = 39999,
        Stock = 14,
        Category = StaticDetails.Products.Categories["Smartwatches"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 3
    },
    new Product() {
        Id = 403,
        ImageURL = "https://os-wordpress-media.s3.ap-south-1.amazonaws.com/blog/wp-content/uploads/2022/01/18235651/Garmin-Fenix-7-Cover.jpg",
        Name = "Garmin Fenix 7",
        LongDescription = "The Garmin Fenix 7 is a rugged smartwatch designed for adventurers, featuring GPS navigation, solar charging, heart rate monitoring, and multiple sports tracking modes for outdoor enthusiasts.",
        ShortDescription = "A durable GPS smartwatch for extreme outdoor adventures.",
        Brand = "Garmin",
        Price = 69999,
        Stock = 7,
        Category = StaticDetails.Products.Categories["Smartwatches"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 2
    },
    new Product() {
        Id = 404,
        ImageURL = "https://imageio.forbes.com/specials-images/imageserve/630c7317962396f5657ec5a1/0x0.jpg?format=jpg&height=900&width=1600&fit=bounds",
        Name = "Fitbit Sense 2",
        LongDescription = "The Fitbit Sense 2 is a health-focused smartwatch with an ECG app, stress management tools, and an improved sensor suite for sleep tracking, making it an excellent choice for wellness enthusiasts.",
        ShortDescription = "A health-centric smartwatch with stress and heart monitoring.",
        Brand = "Fitbit",
        Price = 25999,
        Stock = 20,
        Category = StaticDetails.Products.Categories["Smartwatches"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 2
    },
    new Product() {
        Id = 405,
        ImageURL = "https://us.amazfit.com/cdn/shop/products/PP-_-1_600x600.png?v=1663834312",
        Name = "Amazfit GTR 4",
        LongDescription = "The Amazfit GTR 4 features a stunning AMOLED display, built-in GPS, and an advanced BioTracker sensor for heart rate and SpO2 monitoring. Offers up to 14 days of battery life on a single charge.",
        ShortDescription = "A stylish and long-lasting smartwatch with fitness tracking.",
        Brand = "Amazfit",
        Price = 16999,
        Stock = 25,
        Category = StaticDetails.Products.Categories["Smartwatches"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 5
    },
       new Product() {
        Id = 501,
        ImageURL = "https://os-wordpress-media.s3.ap-south-1.amazonaws.com/blog/wp-content/uploads/2022/09/29112344/Dell-Alienware-Aurora-R15.jpg",
        Name = "Alienware Aurora R15",
        LongDescription = "The Alienware Aurora R15 is a high-performance gaming desktop powered by the Intel Core i9-13900KF processor and NVIDIA GeForce RTX 4090. It features advanced cooling, customizable RGB lighting, and premium build quality.",
        ShortDescription = "A powerful gaming PC with top-tier specs and premium cooling.",
        Brand = "Alienware",
        Price = 389999,
        Stock = 5,
        Category = StaticDetails.Products.Categories["Prebuilt PCs"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 5

    },
    new Product() {
        Id = 502,
        ImageURL = "https://m.media-amazon.com/images/I/71WChkpECLL.jpg",
        Name = "Asus ROG Strix G16",
        LongDescription = "The Asus ROG Strix G16 gaming PC comes with an Intel Core i7-13700KF processor, NVIDIA RTX 4070 Ti GPU, 32GB DDR5 RAM, and a 1TB NVMe SSD. Perfect for high-FPS gaming and content creation.",
        ShortDescription = "A high-performance gaming PC with an RTX 4070 Ti and powerful cooling.",
        Brand = "Asus",
        Price = 229999,
        Stock = 8,
        Category = StaticDetails.Products.Categories["Prebuilt PCs"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 4
    },
    new Product() {
        Id = 503,
        ImageURL = "https://kaas.hpcloud.hp.com/PROD/v2/renderbinary/7573403/5038347/con-win-dt-p-omen-45l-gt22-1015nl-product-specifications/articuno-desktop",
        Name = "HP Omen 45L",
        LongDescription = "The HP Omen 45L gaming desktop features an AMD Ryzen 9 7900X, NVIDIA RTX 4080, 32GB DDR5 RAM, and a unique Cryo Chamber cooling system for extreme performance and efficiency.",
        ShortDescription = "A premium gaming PC with advanced cooling and powerful hardware.",
        Brand = "HP",
        Price = 269999,
        Stock = 6,
        Category = StaticDetails.Products.Categories["Prebuilt PCs"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 5
    },
    new Product() {
        Id = 504,
        ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQMAbfTV4NnUxIDwvzYDthWyZ78yTVZ8uASjw&s",
        Name = "MSI Infinite RS 14th",
        LongDescription = "The MSI Infinite RS 14th gaming PC packs an Intel Core i9-14900KF, NVIDIA RTX 4090, 64GB DDR5 RAM, and a 2TB NVMe SSD, offering ultimate gaming performance and seamless multitasking.",
        ShortDescription = "A beastly gaming PC with the latest Intel and NVIDIA technology.",
        Brand = "MSI",
        Price = 399999,
        Stock = 4,
        Category = StaticDetails.Products.Categories["Prebuilt PCs"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 2
    },
    new Product() {
        Id = 505,
        ImageURL = "https://m.media-amazon.com/images/I/71itNiAeHEL.jpg",
        Name = "CyberPowerPC Gamer Supreme",
        LongDescription = "CyberPowerPC Gamer Supreme is an affordable yet powerful gaming PC with an AMD Ryzen 7 7700X, RTX 4060 Ti, 16GB DDR5 RAM, and a 1TB SSD, offering smooth gaming performance for all modern titles.",
        ShortDescription = "A budget-friendly gaming PC with excellent performance.",
        Brand = "CyberPowerPC",
        Price = 149999,
        Stock = 12,
        Category = StaticDetails.Products.Categories["Prebuilt PCs"],
        PublishDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-rnd.Next(0, 8))),
        Rating = 3
    }
};



            modelBuilder.Entity<Product>().HasData(seedData);
            modelBuilder.Entity<Batch>().HasData(new Batch() { BatchNumber = 10200, BatchDetails = "Some details goes here", Product_Id = 1 });
            modelBuilder.Entity<Order>(o =>
            {
                // Configuration if needed
            });




            base.OnModelCreating(modelBuilder);

        }

    }
}


