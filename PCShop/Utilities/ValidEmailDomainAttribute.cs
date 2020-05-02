using System.ComponentModel.DataAnnotations;

namespace PCShop.Utilities
{
    public class ValidEmailDomainAttribute : ValidationAttribute // Custom attribute validation
    {
        private readonly string allowedDomain;

        public ValidEmailDomainAttribute(string allowedDomain)
        {
            this.allowedDomain = allowedDomain;
        }

        public override bool IsValid(object value)
        {
            string[] strings = value.ToString()?.Split('@');
            return strings != null && strings[1].ToUpper() == allowedDomain.ToUpper();
        }
    }
}