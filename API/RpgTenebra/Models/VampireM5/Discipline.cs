using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RpgTenebra.Models.VampireM5
{
    public class Discipline
    {
        [Key]
        public int DisciplineId { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Name { get; set; }

        [Required]
        public ICollection<DramaRow> Drama { get; set; }

        [Required]
        [Column(TypeName = "varchar(2000)")]
        public string NickName { get; set; }

        [Required]
        public ICollection<DisciplineRow> Description { get; set; }

        [Required]
        public Characteristic Characteristic { get; set; }

        [Required]
        public ICollection<Power> Powers { get; set; }
    }

    public class DramaRow
    {

        [Key]
        public int DramaRowId { get; set; }

        [Required]
        [Column(TypeName = "varchar(2000)")]
        public string Row { get; set; }

    }
    public class DisciplineRow
    {

        [Key]
        public int DisciplineRowId { get; set; }

        [Required]
        [Column(TypeName = "varchar(2000)")]
        public string Row { get; set; }

    }

    public class CharacteristicRow
    {

        [Key]
        public int CharacteristicRowId { get; set; }

        [Required]
        [Column(TypeName = "varchar(2000)")]
        public string Row { get; set; }

    }

    public class Characteristic
    {

        [Key]
        public int CharacteristicId { get; set; }
        [Required]
        public ICollection<CharacteristicRow> Description { get; set; }

    }
}

