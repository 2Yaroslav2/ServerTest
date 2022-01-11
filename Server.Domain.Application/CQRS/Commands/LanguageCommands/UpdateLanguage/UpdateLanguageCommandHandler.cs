using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.LanguageDTO;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.LanguageCommands.UpdateLanguage
{
    public class UpdateLanguageCommandHandler : IRequestHandler<UpdateLanguageCommandRequest, UpdateLanguageCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public UpdateLanguageCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<UpdateLanguageCommandResponse> Handle(UpdateLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            var res = await serviceManagerAsync.LanguageServiceAsync.UpdateAsync(mapper.Map<LanguageUpdateDTO>(request));
            return mapper.Map<UpdateLanguageCommandResponse>(res);
        }
    }
}
