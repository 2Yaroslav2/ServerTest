using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Domain.Application.Dto.CategoryDTO
{
    public class CategoryUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public int CategoryId { get; set; }
    }
}
