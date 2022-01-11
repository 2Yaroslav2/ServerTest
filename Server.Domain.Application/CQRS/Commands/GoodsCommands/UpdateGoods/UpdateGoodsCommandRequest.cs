using MediatR;

namespace Server.Domain.Application.CQRS.Commands.GoodsCommands.UpdateGoods
{
    public class UpdateGoodsCommandRequest : IRequest<UpdateGoodsCommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int NumberOfDays { get; set; }
        public int QuantityInStock { get; set; }
        public int CategoryId { get; set; }
        public double Discount { get; set; }
        public int CountPurchased { get; set; }
        public string Image { get; set; }
    }
}
