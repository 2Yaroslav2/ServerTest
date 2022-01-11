using FluentValidation;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommandRequest>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(user => user.UserName)
                .MaximumLength(36)
                .MinimumLength(3)
                .NotEmpty();
            RuleFor(user => user.Password)
                .MaximumLength(36)
                .MinimumLength(3)
                .NotEmpty()
                .Equal(user => user.PasswordConfirm).WithMessage("'Password' must be equal to 'Password Confirm'").ToString(); 
            RuleFor(user => user.Email)
               .MaximumLength(40)
               .MinimumLength(6)
               .EmailAddress()
               .NotEmpty();
        }
    }
}
