using AutoMapper;
using MediatR;
using Server.Domain.Application.Dto.UserDTO;
using Server.Domain.Application.Interfaces.Servies;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Domain.Application.CQRS.Commands.UserCommands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly IServiceManagerAsync serviceManagerAsync;
        private readonly IMapper mapper;
        public CreateUserCommandHandler(IServiceManagerAsync serviceManagerAsync, IMapper mapper)
        {
            this.serviceManagerAsync = serviceManagerAsync;
            this.mapper = mapper;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {

            //if (request.Password.Equals(request.PasswordConfirm))
            //{
            //    var user = mapper.Map<UserCreateDTO>(request);
            //    var res = await serviceManagerAsync.UserServiceAsync.CreateAsync(user, request.Password);

            //    return new CreateUserCommandResponse { IdentityResult = res };
            //    //return mapper.Map<CreateUserCommandResponse>(res);
            //}
            //else
            //{
            //    return null;
            //}

            var user = mapper.Map<UserCreateDTO>(request);
            var res = await serviceManagerAsync.UserServiceAsync.CreateAsync(user, request.Password);

            return new CreateUserCommandResponse { IdentityResult = res };

        }

    }
}
