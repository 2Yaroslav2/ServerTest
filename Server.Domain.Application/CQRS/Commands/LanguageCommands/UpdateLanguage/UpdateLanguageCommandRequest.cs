using MediatR;

namespace Server.Domain.Application.CQRS.Commands.LanguageCommands.UpdateLanguage
{
    public class UpdateLanguageCommandRequest : IRequest<UpdateLanguageCommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
