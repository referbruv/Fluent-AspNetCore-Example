using FluentValidation;
using System;

namespace FluentMyProfileApp.Models.Validators
{
    public class ProfileVmValidator : AbstractValidator<ProfileVm>
    {
        public ProfileVmValidator(IValidator<AddressInfo> addressInfoValidator)
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.EmailAddress).NotEmpty().EmailAddress();
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.DateOfBirth).InclusiveBetween(new DateTime(1971, 1, 1), DateTime.Now.AddYears(-10));
            RuleFor(x => x.PrimaryAddress).SetValidator(addressInfoValidator);
        }
    }
}