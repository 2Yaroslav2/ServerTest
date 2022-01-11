using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.CategoryCommands.UpdateCategory
{
    public class UpdateCategoryCommandRequest: IRequest<UpdateCategoryCommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public int CategoryId { get; set; }
    }
}
