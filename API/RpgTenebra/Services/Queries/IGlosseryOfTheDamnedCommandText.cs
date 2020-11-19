

namespace RpgTenebra.Services.Queries
{
    public interface IGlosseryOfTheDamnedCommandText
    {
        string GetGlosseryOfTheDamneds { get; }
        string GetGlosseryOfTheDamnedById { get; }
        string AddGlosseryOfTheDamned { get; }
        string UpdateGlosseryOfTheDamned { get; }
        string RemoveGlosseryOfTheDamned { get; }
        string GetGlosseryOfTheDamnedByIdSp { get; }
    }
}
