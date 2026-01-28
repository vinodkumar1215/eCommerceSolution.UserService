using eCommerce.Core.DTO;
using FluentValidation;

namespace eCommerce.Core.Validators;

public class LoginRequestValidator : AbstractValidator<LoginRequest>
{
public LoginRequestValidator()
    {
        RuleFor(temp => temp.Email)
            .NotEmpty().WithMessage("Email should not be empty")
            .EmailAddress().WithMessage("Invalid Email Address");

        RuleFor(temp => temp.Password)
            .NotEmpty().WithMessage("Password should not be empty");
    }
}
