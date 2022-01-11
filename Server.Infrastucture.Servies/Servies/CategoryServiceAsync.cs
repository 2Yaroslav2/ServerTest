using AutoMapper;
using Server.Domain.Application.Dto.CategoryDTO;
using Server.Domain.Application.Interfaces.Servies;
using Server.Domain.Application.Interfaces.UnitOfWork;
using Server.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastucture.Servies.Servies
{
    public class CategoryServiceAsync : ICategoryServiceAsync
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryServiceAsync(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<CategoryViewDTO> CreateAsync(CategoryCreateDTO value)
        {
            var res = await unitOfWork.CategoryRepositoryAsync.CreateAsync(mapper.Map<Category>(value));
            return mapper.Map<CategoryViewDTO>(res);
        }

        public async Task<CategoryViewDTO> DeleteAsync(int id)
        {
            return mapper.Map<CategoryViewDTO>(await unitOfWork.CategoryRepositoryAsync.DeleteAsync(id));
        }

        public async Task<IEnumerable<CategoryViewDTO>> GetAllAsync()
        {
            var res = await unitOfWork.CategoryRepositoryAsync.GetAllAsync();
            return mapper.Map<IEnumerable<CategoryViewDTO>>(res);
        }

        public async Task<CategoryViewDTO> GetByIdAsync(int id)
        {
            var res = await unitOfWork.CategoryRepositoryAsync.GetByIdAsync(id);
            return mapper.Map<CategoryViewDTO>(res);
        }

        public async Task<IEnumerable<CategoryViewDTO>> GetWhereAsync(int languageId)
        {
            var res = await unitOfWork.CategoryRepositoryAsync.GetWhereAsync(value=> value.LanguageId.Equals(languageId));
            return mapper.Map<IEnumerable<CategoryViewDTO>>(res);
        }

        public async Task<CategoryViewDTO> UpdateAsync(CategoryUpdateDTO value)
        {
            var res = await unitOfWork.CategoryRepositoryAsync.UpdateAsync(mapper.Map<Category>(value));
            return mapper.Map<CategoryViewDTO>(res);
        }
    }
}
