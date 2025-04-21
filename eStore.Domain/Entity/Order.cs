using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace eStore.Domain.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public string UserId { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public DateOnly OrderDate { get; set; }

        public string PublicId { get; set; } = string.Empty;
        [ValidateNever]
        public Product Product { get; set; }

        [NotMapped]
        [ValidateNever]
        public OrderDetails OrderDetails { get; set; }
    }
}
