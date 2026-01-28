using eCommerce.Core.DTO;
using FluentValidation;

namespace eCommerce.Core.Validators;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator ()
    {
        RuleFor(temp => temp.Email)
            .NotEmpty().WithMessage("Email should not be empty")
            .EmailAddress().WithMessage("Invalid Email Address");

        RuleFor(temp => temp.Password)
            .NotEmpty().WithMessage("Password should not be empty");

        RuleFor(temp => temp.PersonName)
            .NotEmpty().WithMessage("Person Name should not be empty")
            .MinimumLength(4).WithMessage("Person Name should be at least 4 characters");
}

}
