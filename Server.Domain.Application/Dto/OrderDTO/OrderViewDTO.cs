using System;

namespace Server.Domain.Application.Dto.OrderDTO
{
    public class OrderViewDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int GoodsId { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
        public bool Close { get; set; }
        public int StatusId { get; set; }
    }
}
