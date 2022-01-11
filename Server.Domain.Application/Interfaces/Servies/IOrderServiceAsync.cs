using Server.Domain.Application.Dto.OrderDTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain.Application.Interfaces.Servies
{
    public interface IOrderServiceAsync
    {
        Task<IEnumerable<OrderViewDTO>> GetAllAsync();
        Task<IEnumerable<OrderViewDTO>> GetWhereAsync(Expression<Func<OrderViewDTO, bool>> expression);
        Task<OrderViewDTO> GetByIdAsync(int id);
        Task<OrderViewDTO> CreateAsync(OrderCreateDTO orderCreateDTO);
        Task<OrderViewDTO> DeleteAsync(int id);
        Task<OrderViewDTO> UpdateAsync(OrderUpdateDTO orderUpdateDTO);
    }
}
