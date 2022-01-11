using AutoMapper;
using Server.Domain.Application.Dto.OrderStatusDTO;
using Server.Domain.Application.Interfaces.Servies;
using Server.Domain.Application.Interfaces.UnitOfWork;
using Server.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastucture.Servies.Servies
{
    public class OrderStatusServiceAsync : IOrderStatusServiceAsync
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public OrderStatusServiceAsync(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<OrderStatusViewDTO> CreateAsync(OrderStatusCreateDTO value)
        {
            var res = await unitOfWork.OrderStatusRepositoryAsync.CreateAsync(mapper.Map<OrderStatus>(value));
            return mapper.Map<OrderStatusViewDTO>(res);
        }

        public async Task<OrderStatusViewDTO> DeleteAsync(int id)
        {
            return mapper.Map<OrderStatusViewDTO>(await unitOfWork.OrderStatusRepositoryAsync.DeleteAsync(id));
        }

        public async Task<IEnumerable<OrderStatusViewDTO>> GetAllAsync()
        {
            return mapper.Map<IEnumerable<OrderStatusViewDTO>>(await unitOfWork.OrderStatusRepositoryAsync.GetAllAsync());
        }

        public async Task<OrderStatusViewDTO> GetByIdAsync(int id)
        {
            return mapper.Map<OrderStatusViewDTO>(await unitOfWork.OrderStatusRepositoryAsync.GetByIdAsync(id));
        }

        public async Task<OrderStatusViewDTO> UpdateAsync(OrderStatusUpdateDTO value)
        {
            var res = await unitOfWork.OrderStatusRepositoryAsync.UpdateAsync(mapper.Map<OrderStatus>(value));
            return mapper.Map<OrderStatusViewDTO>(res);
        }
    }
}
