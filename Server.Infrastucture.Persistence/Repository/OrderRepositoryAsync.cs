using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Core.Entities;
using Server.Infrastucture.Persistence.Database.ApplicationDb;
using Server.Infrastucture.Persistence.Repository.Common;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.Repository
{
    public class OrderRepositoryAsync : BaseRepositoryAsync<Order, int>, IOrderRepositoryAsync
    {
        public OrderRepositoryAsync(ApplicationDbContext context) : base(context)
        {
        }
        // TO DO:
        public async override Task<Order> UpdateAsync(Order value)
        {
            if (value != null)
            {
                var order = await GetByIdAsync(value.Id);

                order.Name = value.Name;
                order.Price = value.Price;
                order.Quantity = value.Quantity;
                order.GoodsId = value.GoodsId;
                order.Close = value.Close;


                await context.SaveChangesAsync();
                return order;
            }
            else
            {
                return null;
            }
        }
    }
}
