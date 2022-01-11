using Server.Domain.Core.Entities;

namespace Server.Domain.Application.Interfaces.Repositories
{
    public interface IOrderRepositoryAsync : IRepositoryAsync<Order, int>
    {
    }
}
