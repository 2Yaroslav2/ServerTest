using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.CategoryCommands.UpdateCategory
{
    public class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommandRequest>
    {
        public UpdateCategoryCommandValidator()
        {
            RuleFor(category => category.Name)
               .NotEmpty()
               .MaximumLength(50)
               .MinimumLength(3);
        }
    }
}
