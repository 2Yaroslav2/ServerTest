using Server.Domain.Application.Dto.LanguageDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Domain.Application.Interfaces.Servies
{
    public interface ILanguageServiceAsync
    {
        Task<IEnumerable<LanguageViewDTO>> GetAllAsync();
        Task<LanguageViewDTO> GetByIdAsync(int id);
        Task<LanguageViewDTO> CreateAsync(LanguageCreateDTO value);
        Task<LanguageViewDTO> DeleteAsync(int id);
        Task<LanguageViewDTO> UpdateAsync(LanguageUpdateDTO value);
    }
}
