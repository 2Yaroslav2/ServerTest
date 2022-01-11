using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Core.Entities;
using Server.Infrastucture.Persistence.Database.ApplicationDb;
using Server.Infrastucture.Persistence.Repository.Common;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.Repository
{
    public class GoodsRepositoryAsync : BaseRepositoryAsync<Goods, int>, IGoodsRepositoryAsync
    {
        public GoodsRepositoryAsync(ApplicationDbContext context) : base(context)
        {
        }
        // TO DO:
        public async override Task<Goods> UpdateAsync(Goods value)
        {
            if (value != null)
            {
                var goods = await GetByIdAsync(value.Id);

                goods.Name = value.Name;
                goods.NumberOfDays = value.NumberOfDays;
                goods.Price = value.Price;
                goods.QuantityInStock = value.QuantityInStock;
                goods.CategoryId = value.CategoryId;
                goods.Discount = value.Discount;
                goods.Image = value.Image;

                await context.SaveChangesAsync();

                return goods;
            }
            else
            {
                return null;
            }
        }
    }
}
