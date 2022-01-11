using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdateLogin
{
    public class UpdateLoginCommandValidator : AbstractValidator<UpdateLoginCommandRequest>
    {
        public UpdateLoginCommandValidator()
        {
            RuleFor(user => user.Email)
               .MaximumLength(40)
               .MinimumLength(6)
               .EmailAddress()
               .NotEmpty();
        }
    }
}
