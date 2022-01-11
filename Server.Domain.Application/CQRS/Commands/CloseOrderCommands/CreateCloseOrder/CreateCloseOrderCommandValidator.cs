using FluentValidation;

namespace Server.Domain.Application.CQRS.Commands.CloseOrderCommands.CreateCloseOrder
{
    public class CreateCloseOrderCommandValidator : AbstractValidator<CreateCloseOrderCommandRequest>
    {
        public CreateCloseOrderCommandValidator()
        {
            RuleFor(order => order.Name)
               .NotEmpty();

            RuleFor(order => order.Quantity)
                .NotNull()
                .Must(quatity => quatity > 0)
                .WithMessage("Quantity in stock can't be null and not less than 0");

            RuleFor(order => order.Price)
                .NotNull()
                .Must(price => price > 0)
                .WithMessage("Price can't be null and not less than 0");

            RuleFor(order => order.Date)
                .NotEmpty();

            RuleFor(order => order.UserId)
                .NotEmpty();

            RuleFor(order => order.GoodsId)
                .NotNull();
        }
    }
}
