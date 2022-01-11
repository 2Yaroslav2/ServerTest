using Server.Domain.Application.Dto.GoodsDescriptionDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Domain.Application.Interfaces.Servies
{
    public interface IGoodsDescriptionServiceAsync
    {
        Task<IEnumerable<GoodsDescriptionViewDTO>> GetAllAsync();
        Task<GoodsDescriptionViewDTO> GetWhereAsync(int goodsId, int languageId);
        Task<GoodsDescriptionViewDTO> GetByIdAsync(int id);
        Task<GoodsDescriptionViewDTO> CreateAsync(GoodsDescriptionCreateDTO value);
        Task<GoodsDescriptionViewDTO> DeleteAsync(int id);
        Task<GoodsDescriptionViewDTO> UpdateAsync(GoodsDescriptionUpdateDTO value);
    }
}
