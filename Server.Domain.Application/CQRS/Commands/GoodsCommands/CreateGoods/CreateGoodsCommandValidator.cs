using FluentValidation;

namespace Server.Domain.Application.CQRS.Commands.GoodsCommands.CreateGoods
{
    public class CreateGoodsCommandValidator : AbstractValidator<CreateGoodsCommandRequest>
    {
        // TO DO:
        public CreateGoodsCommandValidator()
        {
            RuleFor(goods => goods.Name)
                .NotEmpty()
                .MaximumLength(36)
                .MinimumLength(3);

            RuleFor(goods => goods.Price)
                .NotNull()
                .Must(price => price > 0)
                .WithMessage("Price can't be null and not less than 0");

            RuleFor(goods => goods.QuantityInStock)
                .NotNull()
                .Must(quantityInStock => quantityInStock > 0)
                .WithMessage("Quantity in stock can't be null and not less than 0");
        }
    }
}
