using Microsoft.EntityFrameworkCore;
using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Core.Common;
using Server.Infrastucture.Persistence.Database.ApplicationDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.Repository.Common
{
    public abstract class BaseRepositoryAsync<TValue, TKey> : IRepositoryAsync<TValue, TKey>
        where TValue : BaseEntity<TKey>
        where TKey : struct
    {
        protected ApplicationDbContext context;

        public BaseRepositoryAsync(ApplicationDbContext context)
        {
            this.context = context;
        }

        private DbSet<TValue> Table { get => context.Set<TValue>(); }

        public async Task<TValue> CreateAsync(TValue value)
        {
            ;
            context.Entry(value).State = EntityState.Added;
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<TValue> DeleteAsync(TKey id)
        {
            TValue value = await GetByIdAsync(id).ConfigureAwait(false);
            context.Entry(value).State = EntityState.Deleted;
            await context.SaveChangesAsync();

            return value;
        }

        public async Task<IEnumerable<TValue>> GetAllAsync()
        {
            return await Table.ToListAsync().ConfigureAwait(false);
        }

        public async Task<TValue> GetByIdAsync(TKey id)
        {
            return await Table.FirstOrDefaultAsync(value => value.Id.Equals(id));
        }

        public async Task<IEnumerable<TValue>> GetWhereAsync(Expression<Func<TValue, bool>> expression)
        {
            return await Table.Where(expression).ToListAsync();
        }

        public abstract Task<TValue> UpdateAsync(TValue value);

    }
}
