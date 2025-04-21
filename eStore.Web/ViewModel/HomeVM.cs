using eStore.Domain.Entity;

namespace eStore.Web.ViewModel
{
    public class HomeVM
    {
        public IEnumerable<Product>? ProductList { get; set; }
        public int Nights { get; set; }
        public DateOnly? FromDate { get; set; }
        public int Rating { get; set; }
    }
}
