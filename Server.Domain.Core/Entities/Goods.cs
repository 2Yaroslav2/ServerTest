using Server.Domain.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Core.Entities
{
    public class Goods : BaseEntity<int>
    {
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
