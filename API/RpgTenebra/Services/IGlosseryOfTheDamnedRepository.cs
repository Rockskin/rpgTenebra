using RpgTenebra.Models.VampireM5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgTenebra.Services
{
    public interface IGlosseryOfTheDamnedRepository
    {

        ValueTask<GlosseryOfTheDamned> GetById(int id);
        Task AddGlosseryOfTheDamned(GlosseryOfTheDamned entity);
        Task UpdateGlosseryOfTheDamned(GlosseryOfTheDamned entity, int id);
        Task RemoveGlosseryOfTheDamned(int id);
        Task<IEnumerable<GlosseryOfTheDamned>> GetAllGlosseryOfTheDamneds();
    }
}
