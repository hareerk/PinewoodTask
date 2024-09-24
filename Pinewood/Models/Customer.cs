using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Pinewood.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "You must provide a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must provide an address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "You must provide an email address")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid email address provided")]
        public string Email { get; set; }

    }
}
