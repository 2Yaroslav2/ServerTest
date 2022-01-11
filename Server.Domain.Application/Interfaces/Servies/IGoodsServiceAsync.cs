using Server.Domain.Application.Dto.GoodsDTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain.Application.Interfaces.Servies
{
    public interface IGoodsServiceAsync
    {
        Task<IEnumerable<GoodsViewDTO>> GetAllAsync();
        Task<IEnumerable<GoodsViewDTO>> GetWhereAsync();
        Task<GoodsViewDTO> GetByIdAsync(int id);
        Task<GoodsViewDTO> CreateAsync(GoodsCreateDTO goodsCreateDTO);
        Task<GoodsViewDTO> DeleteAsync(int id);
        Task<GoodsViewDTO> UpdateAsync(GoodsUpdateDTO goodsUpdateDTO);
    }
}
