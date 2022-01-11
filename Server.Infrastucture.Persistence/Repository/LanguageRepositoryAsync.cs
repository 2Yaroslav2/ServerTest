using Server.Domain.Application.Interfaces.Repositories;
using Server.Domain.Core.Entities;
using Server.Infrastucture.Persistence.Database.ApplicationDb;
using Server.Infrastucture.Persistence.Repository.Common;
using System;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.Repository
{
    public class LanguageRepositoryAsync : BaseRepositoryAsync<Language, int>, ILanguageRepositoryAsync
    {
        public LanguageRepositoryAsync(ApplicationDbContext context) : base(context)
        {
        }

        public async override Task<Language> UpdateAsync(Language value)
        {
            if (value != null)
            {
                var language = await GetByIdAsync(value.Id);

                language.Name = value.Name;

                await context.SaveChangesAsync();

                return language;
            }
            else
            {
                return null;
            }
        }
    }
}
