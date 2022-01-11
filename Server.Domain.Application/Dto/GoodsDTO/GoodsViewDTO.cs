using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.Dto.GoodsDTO
{
    public class GoodsViewDTO
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
