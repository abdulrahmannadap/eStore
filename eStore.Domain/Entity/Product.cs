using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace eStore.Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;

        public string? LongDescription { get; set; } = string.Empty;

        public double Price { get; set; }

        public string Brand { get; set; } = string.Empty;

        public int Stock { get; set; }
        public string? ImageURL { get; set; } = string.Empty;

        public DateOnly PublishDate { get; set; }
        public DateOnly? UpdateDate { get; set; }
        public string OrderStage { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        [NotMapped]
        public IFormFile? Image { get; set; }
        [ValidateNever]
        public ICollection<TargetAudience> TargetAudienceList { get; set; }
        [NotMapped]
        public bool IsOutOfStock = false;
        public int Rating { get; set; }

        [NotMapped]
        public bool IsOrderForm = false;

    }
}
