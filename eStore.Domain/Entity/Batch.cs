using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace eStore.Domain.Entity
{
    public class Batch
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BatchNumber { get; set; }
        public string? BatchDetails { get; set; }

        [ValidateNever]
        public Product Product { get; set; }
        [ForeignKey(nameof(Product))]
        public int Product_Id { get; set; }

    }
}
