using Microsoft.EntityFrameworkCore;
using Server.Domain.Application.Interfaces.Context;
using Server.Domain.Core.Entities;

namespace Server.Infrastucture.Persistence.Database.ApplicationDb
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CloseOrder> CloseOrder { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<GoodsDescription> GoodsDescriptions { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
