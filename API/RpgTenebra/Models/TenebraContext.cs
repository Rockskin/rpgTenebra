using Microsoft.EntityFrameworkCore;
using RpgTenebra.Models.VampireM5;

namespace RpgTenebra.Models
{
    public class TenebraContext : DbContext
    {
        public TenebraContext(DbContextOptions<TenebraContext> options) : base(options)
        { }

        public DbSet<GlosseryOfTheDamned> GlosseryOfTheDamned { get; set; }



        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<DramaRow> DramaRows { get; set; }
        public DbSet<DisciplineRow> DisciplineRows { get; set; }
        public DbSet<CharacteristicRow> CharacteristicRows { get; set; }
        public DbSet<PowerDescriptionRow> PowerDescriptionRows { get; set; }
        public DbSet<PowerSystemRow> PowerSystemRows { get; set; }
    }
}


