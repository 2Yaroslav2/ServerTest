using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.GoodsDescriptionCommands.UpdateGoodsDescription
{
    public class UpdateGoodsDescriptionCommandValidator : AbstractValidator<UpdateGoodsDescriptionCommandRequest>
    {
        public UpdateGoodsDescriptionCommandValidator()
        {
            RuleFor(goodsDescription => goodsDescription.Description)
                  .NotEmpty();
            RuleFor(goodsDescription => goodsDescription.GoodsId)
               .NotEmpty();
            RuleFor(goodsDescription => goodsDescription.LanguageId)
               .NotEmpty();
        }
    }
}
