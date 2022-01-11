using Server.Domain.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Core.Entities
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public int CategoryId { get; set; }
    }
}
