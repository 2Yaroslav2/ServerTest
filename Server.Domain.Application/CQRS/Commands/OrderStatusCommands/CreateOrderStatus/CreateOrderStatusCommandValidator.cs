using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.OrderStatusCommands.CreateOrderStatus
{
    public class CreateOrderStatusCommandValidator : AbstractValidator<CreateOrderStatusCommandRequest>
    {
        public CreateOrderStatusCommandValidator()
        {
            RuleFor(category => category.Name)
               .NotEmpty()
               .MaximumLength(50)
               .MinimumLength(3);
        }
    }
}
