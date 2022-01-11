﻿using MediatR;
using System;

namespace Server.Domain.Application.CQRS.Commands.CloseOrderCommands.UpdateCloseOrder
{
    public class UpdateCloseOrderCommandRequest : IRequest<UpdateCloseOrderCommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int GoodsId { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime EndDate { get; set; }
    }
}
