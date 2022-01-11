using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Core.Entities;
using Server.Infrastucture.Persistence.Database.ApplicationDb;
using Server.Infrastucture.Persistence.Repository.Common;
using System;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.Repository
{
    public class GoodsDescriptionRepositoryAsync : BaseRepositoryAsync<GoodsDescription, int>, IGoodsDescriptionRepositoryAsync
    {
        public GoodsDescriptionRepositoryAsync(ApplicationDbContext context) : base(context)
        {
        }

        public async override Task<GoodsDescription> UpdateAsync(GoodsDescription value)
        {
            if (value != null)
            {
                var goodsDescription = await GetByIdAsync(value.Id);

                goodsDescription.Description = value.Description;
                goodsDescription.GoodsId = value.GoodsId;
                goodsDescription.LanguageId = value.LanguageId;

                await context.SaveChangesAsync();

                return goodsDescription;
            }
            else
            {
                return null;
            }
        }
    }
}
