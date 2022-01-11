using Server.Domain.Application.Dto.OrderStatusDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Domain.Application.Interfaces.Servies
{
    public interface IOrderStatusServiceAsync
    {
        Task<IEnumerable<OrderStatusViewDTO>> GetAllAsync();
        Task<OrderStatusViewDTO> GetByIdAsync(int id);
        Task<OrderStatusViewDTO> CreateAsync(OrderStatusCreateDTO value);
        Task<OrderStatusViewDTO> DeleteAsync(int id);
        Task<OrderStatusViewDTO> UpdateAsync(OrderStatusUpdateDTO value);
    }
}
