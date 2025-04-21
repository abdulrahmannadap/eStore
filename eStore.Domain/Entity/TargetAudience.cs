using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace eStore.Domain.Entity
{
    public class TargetAudience
    {
        [Key]
        public int Id { get; set; }

        public string Audience { get; set; } = "All";
        public string Description { get; set; } = string.Empty;

        [ValidateNever, InverseProperty("TargetAudienceList")]
        public Product Product { get; set; }

        [ForeignKey("Product")]
        public int Product_Id { get; set; }
    }
}
