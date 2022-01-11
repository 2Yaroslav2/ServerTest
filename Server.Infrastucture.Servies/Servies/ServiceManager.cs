using AutoMapper;
using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Application.Interfaces.Servies;
using Server.Domain.Application.Interfaces.UnitOfWork;
using System;

namespace Server.Infrastucture.Servies.Servies
{
    public class ServiceManager : IServiceManagerAsync
    {
        private readonly Lazy<IGoodsServiceAsync> goodsServiceAsync;
        private readonly Lazy<IUserServiceAsync> userServiceAsync;
        private readonly Lazy<IOrderServiceAsync> orderServiceAsync;
        private readonly Lazy<ICloseOrderServiceAsync> closeOrderServiceAsync;
        private readonly Lazy<ICategoryServiceAsync> categoryServiceAsync;
        private readonly Lazy<IOrderStatusServiceAsync> orderStatusServiceAsync;
        private readonly Lazy<ILanguageServiceAsync> languageServiceAsync;
        private readonly Lazy<IGoodsDescriptionServiceAsync> goodsDescriptionServiceAsync;


        public IGoodsServiceAsync GoodsServiceAsync => goodsServiceAsync.Value;
        public IUserServiceAsync UserServiceAsync => userServiceAsync.Value;
        public IOrderServiceAsync OrderServiceAsync => orderServiceAsync.Value;
        public ICloseOrderServiceAsync CloseOrderServiceAsync => closeOrderServiceAsync.Value;
        public ICategoryServiceAsync CategoryServiceAsync => categoryServiceAsync.Value;
        public IOrderStatusServiceAsync OrderStatusServiceAsync => orderStatusServiceAsync.Value;
        public ILanguageServiceAsync LanguageServiceAsync => languageServiceAsync.Value;
        public IGoodsDescriptionServiceAsync GoodsDescriptionServiceAsync => goodsDescriptionServiceAsync.Value;


        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper, IUserRepositoryAsync userRepositoryAsync)
        {
            goodsServiceAsync = new Lazy<IGoodsServiceAsync>(() => new GoodsServiceAsync(unitOfWork, mapper));
            userServiceAsync = new Lazy<IUserServiceAsync>(() => new UserServiceAsync(userRepositoryAsync, mapper));
            orderServiceAsync = new Lazy<IOrderServiceAsync>(() => new OrderServiceAsync(unitOfWork, mapper));
            closeOrderServiceAsync = new Lazy<ICloseOrderServiceAsync>(() => new CloseOrderServiceAsync(unitOfWork, mapper));
            categoryServiceAsync = new Lazy<ICategoryServiceAsync>(() => new CategoryServiceAsync(unitOfWork, mapper));
            orderStatusServiceAsync = new Lazy<IOrderStatusServiceAsync>(() => new OrderStatusServiceAsync(unitOfWork, mapper));
            languageServiceAsync = new Lazy<ILanguageServiceAsync>(() => new LanguageServiceAsync(unitOfWork, mapper));
            goodsDescriptionServiceAsync = new Lazy<IGoodsDescriptionServiceAsync>(() => new GoodsDescriptionServiceAsync(unitOfWork, mapper));

        }

    }
}
