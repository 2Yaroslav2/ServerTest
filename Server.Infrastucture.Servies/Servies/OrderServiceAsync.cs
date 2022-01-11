using AutoMapper;
using Server.Domain.Application.Dto.OrderDTO;
using Server.Domain.Application.Interfaces.Servies;
using Server.Domain.Application.Interfaces.UnitOfWork;
using Server.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Server.Infrastucture.Servies.Servies
{
    public class OrderServiceAsync : IOrderServiceAsync
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public OrderServiceAsync(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<OrderViewDTO> CreateAsync(OrderCreateDTO value)
        {
            var res = await unitOfWork.OrderRepositoryAsync.CreateAsync(mapper.Map<Order>(value));
            return mapper.Map<OrderViewDTO>(res);
        }

        public async Task<OrderViewDTO> DeleteAsync(int id)
        {
            return mapper.Map<OrderViewDTO>(await unitOfWork.OrderRepositoryAsync.DeleteAsync(id));
        }

        public async Task<IEnumerable<OrderViewDTO>> GetAllAsync()
        {
            return mapper.Map<IEnumerable<OrderViewDTO>>(await unitOfWork.OrderRepositoryAsync.GetAllAsync());
        }

        public async Task<OrderViewDTO> GetByIdAsync(int id)
        {
            return mapper.Map<OrderViewDTO>(await unitOfWork.OrderRepositoryAsync.GetByIdAsync(id));
        }

        public Task<IEnumerable<OrderViewDTO>> GetWhereAsync(Expression<Func<OrderViewDTO, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderViewDTO> UpdateAsync(OrderUpdateDTO value)
        {
            var res = await unitOfWork.OrderRepositoryAsync.UpdateAsync(mapper.Map<Order>(value));
            return mapper.Map<OrderViewDTO>(res);
        }
    }
}
