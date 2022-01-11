using Microsoft.EntityFrameworkCore;
using Server.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.Interfaces.Context
{
    public interface IApplicationDbContext
    {
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CloseOrder> CloseOrder { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<GoodsDescription> GoodsDescriptions { get; set; }
    }
}
