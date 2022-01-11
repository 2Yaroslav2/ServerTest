using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePassword
{
    public class UpdatePasswordCommandValidator : AbstractValidator<UpdatePasswordCommandRequest>
    {
        public UpdatePasswordCommandValidator()
        {
            RuleFor(user => user.OldPassword)
               .MaximumLength(36)
               .MinimumLength(3)
               .NotEmpty();

            RuleFor(user => user.NewPassword)
               .MaximumLength(36)
               .MinimumLength(3)
               .NotEmpty()
               .Equal(user => user.NewPasswordConfirm).WithMessage("'New Password' must be equal to 'New password Confirm'").ToString();

            RuleFor(user => user.NewPasswordConfirm)
               .MaximumLength(36)
               .MinimumLength(3)
               .NotEmpty()
               .Equal(user => user.NewPassword).WithMessage("'New Password Confirm' must be equal to 'New password'").ToString();
        }
    }
}
