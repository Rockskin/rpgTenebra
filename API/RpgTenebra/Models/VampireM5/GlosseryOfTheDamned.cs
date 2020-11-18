using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RpgTenebra.Models.VampireM5
{
    public class GlosseryOfTheDamned
    {
        [Key]
        public int GodId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(750)")]
        public string Description { get; set; }
    }
}
