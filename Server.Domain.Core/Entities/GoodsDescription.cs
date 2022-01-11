using Server.Domain.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Core.Entities
{
    public class GoodsDescription: BaseEntity<int>
    {
        public int GoodsId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
    }
}
