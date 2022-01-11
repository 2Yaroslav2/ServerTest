using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.CategoryCommands.CreateCategory
{
    public class CreateCategoryCommandRequest: IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public int CategoryId { get; set; }
    }
}
