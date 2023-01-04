using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoLocacao.Models
{

    [Table("Configuracoes")]
    public class Configuracao
    {

        [Display(Name = "Código")]
        [Column("Id")]
        public int ConfiguracaoId { get; set; }

        [Display(Name = "Dias de Locação")]
        [Column("Dias de Locacao")]

        public int DiasDeLocacao { get; set; }
    }
}
