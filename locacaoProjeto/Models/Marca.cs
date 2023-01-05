using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace locacaoProjeto.Models
{

    [Table("Marcas")]
    public class Marca
    {
        [Display(Name = "Código")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }
    }
}
