using Microsoft.EntityFrameworkCore.Storage;
using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Application.Interfaces.UnitOfWork;
using Server.Infrastucture.Persistence.Database.ApplicationDb;
using Server.Infrastucture.Persistence.Repository;
using System;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.UnitOfWork
{
    public class AppUnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        private readonly Lazy<IGoodsRepositoryAsync> goodsRepositoryAsync;
        private readonly Lazy<IOrderRepositoryAsync> orderRepositoryAsync;
        private readonly Lazy<ICloseOrderRepositoryAsync> closeOrderRepositoryAsync;
        private readonly Lazy<ICategoryRepositoryAsync> categoryRepositoryAsync;
        private readonly Lazy<IOrderStatusRepositoryAsync> orderStatusRepositoryAsync;
        private readonly Lazy<ILanguageRepositoryAsync> languageRepositoryAsync;
        private readonly Lazy<IGoodsDescriptionRepositoryAsync> goodsDescriptionRepositoryAsync;

        public IGoodsRepositoryAsync GoodsRepositoryAsync => goodsRepositoryAsync.Value;
        public IOrderRepositoryAsync OrderRepositoryAsync => orderRepositoryAsync.Value;
        public ICloseOrderRepositoryAsync CloseOrderRepositoryAsync => closeOrderRepositoryAsync.Value;
        public IOrderStatusRepositoryAsync OrderStatusRepositoryAsync => orderStatusRepositoryAsync.Value;
        public ICategoryRepositoryAsync CategoryRepositoryAsync => categoryRepositoryAsync.Value;
        public ILanguageRepositoryAsync LanguageRepositoryAsync => languageRepositoryAsync.Value;
        public IGoodsDescriptionRepositoryAsync GoodsDescriptionRepositoryAsync => goodsDescriptionRepositoryAsync.Value;

        public AppUnitOfWork(ApplicationDbContext context)
        {
            this.context = context;

            goodsRepositoryAsync = new Lazy<IGoodsRepositoryAsync>(() => new GoodsRepositoryAsync(context));
            orderRepositoryAsync = new Lazy<IOrderRepositoryAsync>(() => new OrderRepositoryAsync(context));
            closeOrderRepositoryAsync = new Lazy<ICloseOrderRepositoryAsync>(() => new CloseOrderRepositoryAsync(context));
            categoryRepositoryAsync = new Lazy<ICategoryRepositoryAsync>(() => new CategoryRepositoryAsync(context));
            orderStatusRepositoryAsync = new Lazy<IOrderStatusRepositoryAsync>(() => new OrderStatusRepositoryAsync(context));
            languageRepositoryAsync = new Lazy<ILanguageRepositoryAsync>(() => new LanguageRepositoryAsync(context));
            goodsDescriptionRepositoryAsync = new Lazy<IGoodsDescriptionRepositoryAsync>(() => new GoodsDescriptionRepositoryAsync(context));

        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await context.Database.BeginTransactionAsync();
        }
    }
}
