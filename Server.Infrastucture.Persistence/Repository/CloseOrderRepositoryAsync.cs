using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Core.Entities;
using Server.Infrastucture.Persistence.Database.ApplicationDb;
using Server.Infrastucture.Persistence.Repository.Common;
using System;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.Repository
{
    public class CloseOrderRepositoryAsync : BaseRepositoryAsync<CloseOrder, int>, ICloseOrderRepositoryAsync
    {
        public CloseOrderRepositoryAsync(ApplicationDbContext context) : base(context)
        {
        }
        // TO DO:
        public async override Task<CloseOrder> UpdateAsync(CloseOrder value)
        {
            if (value != null)
            {
                var closeOrder = await GetByIdAsync(value.Id);

                
                closeOrder.Name = value.Name;
                closeOrder.GoodsId = value.GoodsId;
                closeOrder.Price = value.Price;
                closeOrder.TotalPrice = value.TotalPrice;
                closeOrder.Quantity = value.Quantity;
                closeOrder.Close = value.Close;
                closeOrder.StatusId = value.StatusId;

                await context.SaveChangesAsync();

                return closeOrder;
            }
            else
            {
                return null;
            }
        }
    }
}
