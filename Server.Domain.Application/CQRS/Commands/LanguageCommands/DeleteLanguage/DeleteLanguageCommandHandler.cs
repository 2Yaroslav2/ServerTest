using AutoMapper;
using MediatR;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.LanguageCommands.DeleteLanguage
{
    public class DeleteLanguageCommandHandler : IRequestHandler<DeleteLanguageCommandRequest, DeleteLanguageCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public DeleteLanguageCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<DeleteLanguageCommandResponse> Handle(DeleteLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.LanguageServiceAsync.DeleteAsync(request.Id);
            if (res != null)
            {
                return new DeleteLanguageCommandResponse
                {
                    Succeed = true
                };
            }
            else
            {
                return new DeleteLanguageCommandResponse
                {
                    Succeed = false
                };
            }
        }
    }
}
