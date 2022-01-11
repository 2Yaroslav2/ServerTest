using Server.Domain.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Server.Domain.Application.Interfaces.Repositories
{
    public interface IRepositoryAsync<TValue, TKey>
        where TValue : BaseEntity<TKey>
        where TKey : struct
    {
        Task<IEnumerable<TValue>> GetAllAsync();
        Task<IEnumerable<TValue>> GetWhereAsync(Expression<Func<TValue, bool>> expression);
        Task<TValue> GetByIdAsync(TKey id);
        Task<TValue> CreateAsync(TValue value);
        Task<TValue> DeleteAsync(TKey id);
        Task<TValue> UpdateAsync(TValue value);
    }
}
