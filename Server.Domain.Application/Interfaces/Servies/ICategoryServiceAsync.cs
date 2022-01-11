using Server.Domain.Application.Dto.CategoryDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Domain.Application.Interfaces.Servies
{
    public interface ICategoryServiceAsync
    {
        Task<IEnumerable<CategoryViewDTO>> GetAllAsync();
        Task<CategoryViewDTO> GetByIdAsync(int id);
        Task<IEnumerable<CategoryViewDTO>> GetWhereAsync(int languageId);
        Task<CategoryViewDTO> CreateAsync(CategoryCreateDTO value);
        Task<CategoryViewDTO> DeleteAsync(int id);
        Task<CategoryViewDTO> UpdateAsync(CategoryUpdateDTO value);
    }
}
