using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.LanguageDTO;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.LanguageCommands.CreateLanguage
{
    public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageCommandRequest, CreateLanguageCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public CreateLanguageCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<CreateLanguageCommandResponse> Handle(CreateLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.LanguageServiceAsync.CreateAsync(mapper.Map<LanguageCreateDTO>(request));
            return mapper.Map<CreateLanguageCommandResponse>(res);
        }
    }
}
