using Microsoft.EntityFrameworkCore.Storage;
using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        IGoodsRepositoryAsync GoodsRepositoryAsync { get; }
        IOrderRepositoryAsync OrderRepositoryAsync { get; }
        ICloseOrderRepositoryAsync CloseOrderRepositoryAsync { get; }
        IOrderStatusRepositoryAsync OrderStatusRepositoryAsync { get; }
        ICategoryRepositoryAsync CategoryRepositoryAsync { get; }
        ILanguageRepositoryAsync LanguageRepositoryAsync { get; }
        IGoodsDescriptionRepositoryAsync GoodsDescriptionRepositoryAsync { get; }
    }
}
