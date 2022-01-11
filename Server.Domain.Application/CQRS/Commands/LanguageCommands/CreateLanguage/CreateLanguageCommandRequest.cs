using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Commands.LanguageCommands.CreateLanguage
{
    public class CreateLanguageCommandRequest : IRequest<CreateLanguageCommandResponse>
    {
        public string Name { get; set; }
    }
}
