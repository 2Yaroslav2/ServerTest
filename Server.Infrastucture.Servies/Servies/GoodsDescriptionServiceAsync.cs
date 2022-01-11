using AutoMapper;
using Server.Domain.Application.Dto.GoodsDescriptionDTO;
using Server.Domain.Application.Interfaces.Servies;
using Server.Domain.Application.Interfaces.UnitOfWork;
using Server.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Infrastucture.Servies.Servies
{
    public class GoodsDescriptionServiceAsync : IGoodsDescriptionServiceAsync
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GoodsDescriptionServiceAsync(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<GoodsDescriptionViewDTO> CreateAsync(GoodsDescriptionCreateDTO value)
        {
            var res = await unitOfWork.GoodsDescriptionRepositoryAsync.CreateAsync(mapper.Map<GoodsDescription>(value));
            ;
            return mapper.Map<GoodsDescriptionViewDTO>(res);
        }

        public async Task<GoodsDescriptionViewDTO> DeleteAsync(int id)
        {
            return mapper.Map<GoodsDescriptionViewDTO>(await unitOfWork.GoodsDescriptionRepositoryAsync.DeleteAsync(id));
        }

        public async Task<IEnumerable<GoodsDescriptionViewDTO>> GetAllAsync()
        {
            var res = await unitOfWork.GoodsDescriptionRepositoryAsync.GetAllAsync();
            return mapper.Map<IEnumerable<GoodsDescriptionViewDTO>>(res);
        }

        public async Task<GoodsDescriptionViewDTO> GetByIdAsync(int id)
        {
            var res = await unitOfWork.GoodsDescriptionRepositoryAsync.GetByIdAsync(id);
            return mapper.Map<GoodsDescriptionViewDTO>(res);
        }

        public async Task<GoodsDescriptionViewDTO> GetWhereAsync(int goodsId, int languageId)
        {
            var descriptions = await unitOfWork.GoodsDescriptionRepositoryAsync
                 .GetWhereAsync(value => value.GoodsId.Equals(goodsId) && value.LanguageId.Equals(languageId));

            if (descriptions != null)
            {
                var res = mapper.Map<List<GoodsDescriptionViewDTO>>(descriptions);
                return res[0];
            }
            else
            {
                return null;
            }
        }

        public async Task<GoodsDescriptionViewDTO> UpdateAsync(GoodsDescriptionUpdateDTO value)
        {
            var res = await unitOfWork.GoodsDescriptionRepositoryAsync.UpdateAsync(mapper.Map<GoodsDescription>(value));
            return mapper.Map<GoodsDescriptionViewDTO>(res);
        }
    }
}
