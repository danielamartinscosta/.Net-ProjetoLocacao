using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoLocacao.Models
{

    [Table("Modelos")]
    public class Modelo
    {

        [Display(Name = "Código")]
        [Column("Id")]
        public int ModeloId { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }
    }
}
