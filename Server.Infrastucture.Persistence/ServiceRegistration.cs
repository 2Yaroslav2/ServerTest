using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Application.Interfaces.UnitOfWork;
using Server.Domain.Core.Entities;
using Server.Infrastucture.Persistence.Database.ApplicationDb;
using Server.Infrastucture.Persistence.Database.UserDb;
using Server.Infrastucture.Persistence.Repository;
using Server.Infrastucture.Persistence.UnitOfWork;

namespace Server.Infrastucture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {

            serviceCollection.AddDbContext<UserDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("UserConnection")));

            serviceCollection.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;

            })
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<UserDbContext>();


            serviceCollection.AddTransient<IUserRepositoryAsync, UserRepositoryAsync>();

            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SQLServer")));

            serviceCollection.AddTransient<IUnitOfWork, AppUnitOfWork>();
            //serviceCollection.AddTransient<IGoodsRepositoryAsync, GoodsRepositoryAsync>();

        }
    }
}
