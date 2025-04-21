using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace eStore.Web.ViewModel
{
    public class RegisterVM
    {
        [Required, DataType(dataType: DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [DisplayName("Confirm Password")]

        public string ConfirmPassword { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone Number")]
        public string? PhoneNumber { get; set; }
        public string? RedirectURL { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> Rolelist { get; set; }
        public string Role { get; set; }

    }
}
