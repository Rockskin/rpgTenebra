using Dapper;
using Microsoft.Extensions.Configuration;
using RpgTenebra.Models.VampireM5;
using RpgTenebra.Services.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RpgTenebra.Services
{
    public class GlosseryOfTheDamnedRepository : BaseRepository, IGlosseryOfTheDamnedRepository
    {
        private readonly IGlosseryOfTheDamnedCommandText _commandText;

        public GlosseryOfTheDamnedRepository(IConfiguration configuration, IGlosseryOfTheDamnedCommandText commandText) : base(configuration)
        {
            _commandText = commandText;

        }

        public async Task<IEnumerable<GlosseryOfTheDamned>> GetAllGlosseryOfTheDamneds()
        {

            return await WithConnection(async conn =>
            {
                var query = await conn.QueryAsync<GlosseryOfTheDamned>(_commandText.GetGlosseryOfTheDamneds);
                return query;
            });

        }

        public async ValueTask<GlosseryOfTheDamned> GetById(int id)
        {
            return await WithConnection(async conn =>
            {
                var query = await conn.QueryFirstOrDefaultAsync<GlosseryOfTheDamned>(_commandText.GetGlosseryOfTheDamnedById, new { Id = id });
                return query;
            });

        }

        public async Task AddGlosseryOfTheDamned(GlosseryOfTheDamned entity)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_commandText.AddGlosseryOfTheDamned,
                    new { entity.Name, entity.Description });
            });

        }
        public async Task UpdateGlosseryOfTheDamned(GlosseryOfTheDamned entity, int id)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_commandText.UpdateGlosseryOfTheDamned,
                    new { entity.Name,  entity.Description, Id = id });
            });

        }
        public async Task RemoveGlosseryOfTheDamned(int id)
        {

            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_commandText.RemoveGlosseryOfTheDamned, new { Id = id });
            });

        }

    }
}
