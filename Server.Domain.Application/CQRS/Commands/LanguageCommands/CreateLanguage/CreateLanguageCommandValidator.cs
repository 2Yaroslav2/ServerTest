using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.LanguageCommands.CreateLanguage
{
    public class CreateLanguageCommandValidator : AbstractValidator<CreateLanguageCommandRequest>
    {
        public CreateLanguageCommandValidator()
        {
            RuleFor(language => language.Name)
               .NotEmpty();
        }
    }
}
