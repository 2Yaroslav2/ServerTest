using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Core.Entities;
using Server.Infrastucture.Persistence.Database.ApplicationDb;
using Server.Infrastucture.Persistence.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.Repository
{
    public class CategoryRepositoryAsync : BaseRepositoryAsync<Category, int>, ICategoryRepositoryAsync
    {
        public CategoryRepositoryAsync(ApplicationDbContext context) : base(context)
        {
        }

        public async override Task<Category> UpdateAsync(Category value)
        {
            if (value != null)
            {
                var category = await GetByIdAsync(value.Id);

                category.Name = value.Name;
                category.LanguageId = value.LanguageId;
                category.CategoryId = value.CategoryId;

                await context.SaveChangesAsync();

                return category;
            }
            else
            {
                return null;
            }
        }
    }
}
