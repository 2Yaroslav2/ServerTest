using Server.Domain.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Core.Entities
{
    public class Language: BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
