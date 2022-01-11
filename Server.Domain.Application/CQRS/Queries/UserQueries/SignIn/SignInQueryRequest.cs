using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.CQRS.Queries.UserQueries.SignIn
{
    public class SignInQueryRequest : IRequest<SignInQueryResponse>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
