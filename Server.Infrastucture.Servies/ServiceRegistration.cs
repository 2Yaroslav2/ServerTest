using Microsoft.Extensions.DependencyInjection;
using Server.Domain.Application.Interfaces.Servies;
using Server.Infrastucture.Servies.Servies;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Server.Infrastucture.Servies
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IServiceManagerAsync, ServiceManager>();
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
