using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoLocacao.Models
{

    [Table("Marcas")]
    public class Marca
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int MarcaId { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }
    }
}
