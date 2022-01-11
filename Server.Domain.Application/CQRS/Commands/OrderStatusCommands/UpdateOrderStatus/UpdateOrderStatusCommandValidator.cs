using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.OrderStatusCommands.UpdateOrderStatus
{
    public class UpdateOrderStatusCommandValidator : AbstractValidator<UpdateOrderStatusCommandRequest>
    {
        public UpdateOrderStatusCommandValidator()
        {
            RuleFor(category => category.Name)
               .NotEmpty()
               .MaximumLength(50)
               .MinimumLength(3);
        }
    }
}
