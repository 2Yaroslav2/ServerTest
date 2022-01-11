using AutoMapper;
using Server.Domain.Application.Dto.CloseOrderDTO;
using Server.Domain.Application.Interfaces.Servies;
using Server.Domain.Application.Interfaces.UnitOfWork;
using Server.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Server.Infrastucture.Servies.Servies
{
    public class CloseOrderServiceAsync : ICloseOrderServiceAsync
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CloseOrderServiceAsync(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<CloseOrderViewDTO> CreateAsync(CloseOrderCreateDTO value)
        {
            var res = await unitOfWork.CloseOrderRepositoryAsync.CreateAsync(mapper.Map<CloseOrder>(value));
            return mapper.Map<CloseOrderViewDTO>(res);
        }

        public async Task<CloseOrderViewDTO> DeleteAsync(int id)
        {
            return mapper.Map<CloseOrderViewDTO>(await unitOfWork.CloseOrderRepositoryAsync.DeleteAsync(id));
        }

        public async Task<IEnumerable<CloseOrderViewDTO>> GetAllAsync()
        {
            return mapper.Map<IEnumerable<CloseOrderViewDTO>>(await unitOfWork.CloseOrderRepositoryAsync.GetAllAsync());
        }

        public async Task<CloseOrderViewDTO> GetByIdAsync(int id)
        {
            return mapper.Map<CloseOrderViewDTO>(await unitOfWork.CloseOrderRepositoryAsync.GetByIdAsync(id));
        }

        public Task<IEnumerable<CloseOrderViewDTO>> GetWhereAsync(Expression<Func<CloseOrderViewDTO, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<CloseOrderViewDTO> UpdateAsync(CloseOrderUpdateDTO value)
        {
            var res = await unitOfWork.CloseOrderRepositoryAsync.UpdateAsync(mapper.Map<CloseOrder>(value));
            return mapper.Map<CloseOrderViewDTO>(res);
        }
    }
}
