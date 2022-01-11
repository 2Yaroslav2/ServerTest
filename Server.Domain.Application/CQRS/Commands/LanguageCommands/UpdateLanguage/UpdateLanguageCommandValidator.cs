using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.LanguageCommands.UpdateLanguage
{
    public class UpdateLanguageCommandValidator: AbstractValidator<UpdateLanguageCommandRequest>
    {
        public UpdateLanguageCommandValidator()
        {
            RuleFor(language => language.Name)
             .NotEmpty();
        }
    }
}
