using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RpgTenebra.Models.VampireM5
{
    public class Power
    {

        [Key]
        public int PowerId { get; set; }

        [Required]
        public int Rank { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Name { get; set; }

        [Required]
        public ICollection<PowerDescriptionRow> Description { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string DicePool { get; set; }

        [Required]
        [Column(TypeName = "varchar(500)")]
        public string Cost { get; set; }

        [Required]
        public ICollection<PowerSystemRow> System { get; set; }

        [Required]
        [Column(TypeName = "varchar(2000)")]
        public string Duration { get; set; }
    }
    public class PowerDescriptionRow
    {

        [Key]
        public int DescriptionRowId { get; set; }

        [Required]
        [Column(TypeName = "varchar(2000)")]
        public string Row { get; set; }

    }

    public class PowerSystemRow
    {

        [Key]
        public int SystemRowId { get; set; }

        [Required]
        [Column(TypeName = "varchar(2000)")]
        public string Row { get; set; }

    }
}

