using AutoMapper;
using Server.Domain.Application.Dto.LanguageDTO;
using Server.Domain.Application.Interfaces.Servies;
using Server.Domain.Application.Interfaces.UnitOfWork;
using Server.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastucture.Servies.Servies
{
    public class LanguageServiceAsync : ILanguageServiceAsync
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public LanguageServiceAsync(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<LanguageViewDTO> CreateAsync(LanguageCreateDTO value)
        {
            var res = await unitOfWork.LanguageRepositoryAsync.CreateAsync(mapper.Map<Language>(value));
            return mapper.Map<LanguageViewDTO>(res);
        }

        public async Task<LanguageViewDTO> DeleteAsync(int id)
        {
            return mapper.Map<LanguageViewDTO>(await unitOfWork.LanguageRepositoryAsync.DeleteAsync(id));
        }

        public async Task<IEnumerable<LanguageViewDTO>> GetAllAsync()
        {
            var res = await unitOfWork.LanguageRepositoryAsync.GetAllAsync();
            return mapper.Map<IEnumerable<LanguageViewDTO>>(res);
        }

        public  async Task<LanguageViewDTO> GetByIdAsync(int id)
        {
            var res = await unitOfWork.LanguageRepositoryAsync.GetByIdAsync(id);
            return mapper.Map<LanguageViewDTO>(res);
        }

        public  async Task<LanguageViewDTO> UpdateAsync(LanguageUpdateDTO value)
        {
            var res = await unitOfWork.LanguageRepositoryAsync.UpdateAsync(mapper.Map<Language>(value));
            return mapper.Map<LanguageViewDTO>(res);
        }
    }
}
