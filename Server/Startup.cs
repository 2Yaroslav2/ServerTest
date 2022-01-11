using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Server.Domain.Application;
using Server.Infrastucture.Business.Attributes;
using Server.Infrastucture.Persistence;
using Server.Infrastucture.Servies;

namespace Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors();
            services.AddApplicationServices();
            services.AddPersistenceServices(Configuration);
            services.AddInfrastructureServices();
        
            services.AddControllers(options => options.Filters.Add<ValidationFilter>())
                .AddFluentValidation(configuration => configuration
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.GoodsCommands.CreateGoods.CreateGoodsCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.GoodsCommands.UpdateGoods.UpdateGoodsCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.OrderCommands.CreateOrder.CreateOrderCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.OrderCommands.UpdateOrder.UpdateOrderCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.CloseOrderCommands.CreateCloseOrder.CreateCloseOrderCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.CloseOrderCommands.UpdateCloseOrder.UpdateCloseOrderCommandValidator>()   
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.UserCommands.CreateUser.CreateUserCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.CategoryCommands.CreateCategory.CreateCategoryCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.CategoryCommands.UpdateCategory.UpdateCategoryCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.OrderStatusCommands.CreateOrderStatus.CreateOrderStatusCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.OrderStatusCommands.UpdateOrderStatus.UpdateOrderStatusCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.GoodsDescriptionCommands.CreateGoodsDescription.CreateGoodsDescriptionCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.GoodsDescriptionCommands.UpdateGoodsDescription.UpdateGoodsDescriptionCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.LanguageCommands.CreateLanguage.CreateLanguageCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.LanguageCommands.UpdateLanguage.UpdateLanguageCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdateContacts.UpdateContactsCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdateLogin.UpdateLoginCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePersonalData.UpdatePersonalDataCommandValidator>()
                    .RegisterValidatorsFromAssemblyContaining<Domain.Application.CQRS.Commands.UserCommands.UpdateUser.UpdatePassword.UpdatePasswordCommandValidator>())
                .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseCors(builder => builder.WithOrigins("http://localhost:4200")
            //                             .AllowAnyHeader()
            //                             .AllowAnyMethod()
            //                             .AllowCredentials());

            app.UseCors(builder => builder.AllowAnyOrigin()
                                        .AllowAnyHeader()
                                        .AllowAnyMethod());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller}/{action=Index}/{id?}");
            });
        }
    }
}
