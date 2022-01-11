using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Core.Common
{
    public abstract class BaseEntity<TKey> where TKey : struct
    {
        public TKey Id { get; set; }
    }
}
