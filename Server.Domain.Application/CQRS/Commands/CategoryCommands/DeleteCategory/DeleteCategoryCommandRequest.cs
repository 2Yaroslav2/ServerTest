using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.CategoryCommands.DeleteCategory
{
    public class DeleteCategoryCommandRequest: IRequest<DeleteCategoryCommandResponse>
    {
        public int Id { get; set; }
    }
}
