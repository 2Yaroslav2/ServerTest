using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.Interfaces.Servies
{
    public interface IServiceManagerAsync
    {
        IGoodsServiceAsync GoodsServiceAsync { get; }
        IOrderServiceAsync OrderServiceAsync { get; }
        ICloseOrderServiceAsync CloseOrderServiceAsync { get; }
        IUserServiceAsync UserServiceAsync { get; }
        ICategoryServiceAsync CategoryServiceAsync { get; }
        IOrderStatusServiceAsync OrderStatusServiceAsync { get; }
        ILanguageServiceAsync LanguageServiceAsync { get; }
        IGoodsDescriptionServiceAsync GoodsDescriptionServiceAsync { get; }
    }
}
