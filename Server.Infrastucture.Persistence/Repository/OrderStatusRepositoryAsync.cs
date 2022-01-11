using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Core.Entities;
using Server.Infrastucture.Persistence.Database.ApplicationDb;
using Server.Infrastucture.Persistence.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.Repository
{
    public class OrderStatusRepositoryAsync : BaseRepositoryAsync<OrderStatus, int>, IOrderStatusRepositoryAsync
    {
        public OrderStatusRepositoryAsync(ApplicationDbContext context) : base(context)
        {
        }

        public async override Task<OrderStatus> UpdateAsync(OrderStatus value)
        {
            if (value != null)
            {
                var orderStatus = await GetByIdAsync(value.Id);

                orderStatus.Name = value.Name;
                orderStatus.LanguageId = value.LanguageId;

                await context.SaveChangesAsync();

                return orderStatus;
            }
            else
            {
                return null;
            }
        }
    }
}
