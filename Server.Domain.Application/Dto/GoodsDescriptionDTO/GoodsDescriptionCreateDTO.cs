using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.Dto.GoodsDescriptionDTO
{
    public class GoodsDescriptionCreateDTO
    {
        public int GoodsId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
    }
}
