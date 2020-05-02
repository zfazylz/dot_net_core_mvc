using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PCShop.Models
{
    // Internal validation for each property of model
    public class Order: IValidatableObject
    {
        [BindNever]
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Please enter your first name")] // Error message when method throws
        [Display(Name = "First Name")] // Displaying name on front end
        [StringLength(25)] // And validation for max length of property and it is also required property
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Street Address")]
        [StringLength(100)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter your state")]
        [StringLength(2, MinimumLength = 2)]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter your zip")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter your phone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            object[] zipCodes=new object[2]{10001, 10002};
            if (!zipCodes.Contains(ZipCode))
            {
                yield return new ValidationResult("We do not deliver to that Zip Code");
            }
        }
    }
}
