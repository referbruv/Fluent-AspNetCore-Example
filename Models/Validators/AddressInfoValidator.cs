using FluentValidation;
using System.Text.RegularExpressions;

namespace FluentMyProfileApp.Models.Validators
{
    public class AddressInfoValidator : AbstractValidator<AddressInfo>
    {
        public AddressInfoValidator()
        {
            RuleFor(x => x.Line1).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.State).NotEmpty();
            RuleFor(x => x.Country).NotEmpty();
            RuleFor(x => x.Pincode).NotEmpty()
                .MinimumLength(6).MaximumLength(6).Must(x => !string.IsNullOrEmpty(x) && Regex.IsMatch(x, @"^\d$")).WithMessage("Invalid Pincode");
        }
    }
}