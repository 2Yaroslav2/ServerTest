using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePersonalData
{
    public class UpdatePersonalDataCommandValidator : AbstractValidator<UpdatePersonalDataCommandRequest>
    {
        public UpdatePersonalDataCommandValidator()
        {
            RuleFor(user => user.UserName)
                .MaximumLength(36)
                .MinimumLength(3)
                .NotEmpty();
        }
    }
}
