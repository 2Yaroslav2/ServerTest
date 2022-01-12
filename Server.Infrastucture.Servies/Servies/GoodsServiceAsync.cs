using AutoMapper;
using Server.Domain.Application.Dto.GoodsDTO;
using Server.Domain.Application.Interfaces.Servies;
using Server.Domain.Application.Interfaces.UnitOfWork;
using Server.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Server.Infrastucture.Servies.Servies
{
    public class GoodsServiceAsync : IGoodsServiceAsync
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GoodsServiceAsync(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<GoodsViewDTO> CreateAsync(GoodsCreateDTO value)
        {
            ;
            var res = await unitOfWork.GoodsRepositoryAsync.CreateAsync(mapper.Map<Goods>(value));
            ;
            return mapper.Map<GoodsViewDTO>(res);
        }

        public async Task<GoodsViewDTO> DeleteAsync(int id)
        {
            return mapper.Map<GoodsViewDTO>(await unitOfWork.GoodsRepositoryAsync.DeleteAsync(id));
        }

        public async Task<IEnumerable<GoodsViewDTO>> GetAllAsync()
        {
            return mapper.Map<IEnumerable<GoodsViewDTO>>(await unitOfWork.GoodsRepositoryAsync.GetAllAsync());
        }

        public async Task<GoodsViewDTO> GetByIdAsync(int id)
        {
            return mapper.Map<GoodsViewDTO>(await unitOfWork.GoodsRepositoryAsync.GetByIdAsync(id));
        }

        public async Task<IEnumerable<GoodsViewDTO>> GetWhereAsync()
        {
          
            ;
            return null;
        }

        public async Task<GoodsViewDTO> UpdateAsync(GoodsUpdateDTO value)
        {
            var res = await unitOfWork.GoodsRepositoryAsync.UpdateAsync(mapper.Map<Goods>(value));
            return mapper.Map<GoodsViewDTO>(res);
        }
    }
}
