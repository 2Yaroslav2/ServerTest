using Server.Domain.Application.Dto.CloseOrderDTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Server.Domain.Application.Interfaces.Servies
{
    public interface ICloseOrderServiceAsync
    {
        Task<IEnumerable<CloseOrderViewDTO>> GetAllAsync();
        Task<IEnumerable<CloseOrderViewDTO>> GetWhereAsync(Expression<Func<CloseOrderViewDTO, bool>> expression);
        Task<CloseOrderViewDTO> GetByIdAsync(int id);
        Task<CloseOrderViewDTO> CreateAsync(CloseOrderCreateDTO value);
        Task<CloseOrderViewDTO> DeleteAsync(int id);
        Task<CloseOrderViewDTO> UpdateAsync(CloseOrderUpdateDTO value);
    }
}
