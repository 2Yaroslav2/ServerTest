using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.UserDTO;
using Server.Domain.Application.Interfaces.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Queries.UserQueries.SignIn
{
    public class SignInQueryHandler : IRequestHandler<SignInQueryRequest, SignInQueryResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;

        public SignInQueryHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<SignInQueryResponse> Handle(SignInQueryRequest request, CancellationToken cancellationToken)
        {
            var signInDTO = mapper.Map<UserSignInDTO>(request);
            var user = await serviceManagerAsync.UserServiceAsync.SignInAsync(signInDTO);
            ;
            return mapper.Map<SignInQueryResponse>(user);
        }
    }
}
