using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.LanguageCommands.DeleteLanguage
{
    public class DeleteLanguageCommandRequest: IRequest<DeleteLanguageCommandResponse>
    {
        public int Id { get; set; }
    }
}
