namespace eStore.Application.Utilities
{
    // convention => SubjectName_Topic 
    public static class StaticDetails
    {
        public static class ApplicationUserRoles
        {

            public const string Role_Seller = "seller";
            public const string Role_Customer = "customer";
        }

        public static class Filter
        {
            public static int FilterProduct_Rating__3 = 3;
            public static int FilterProduct_Rating__None = 0;
        }
        public static class Products
        {
            public static Dictionary<string, string> Categories = new Dictionary<string, string>()
            {
                { "Smartphones" , "Smartphones" },
                { "Smartwatches" , "Smart watch" },
                { "Consoles" , "Console" },
                { "Prebuilt PCs" , "Pre build" },
                { "GPU" , "Graphic card" },
            };
            public static class OrderStages
            {
                public static string OrderConfirmed = "ORDER_CONFIRMED";
                public static string Deliveried = "ORDER_DELIEVERED";
            }
        }


    }
}
