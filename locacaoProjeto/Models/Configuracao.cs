using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace locacaoProjeto.Models
{

    [Table("Configuracoes")]
    public class Configuracao
    {
        [Display(Name = "Código")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Dias de Locação")]
        [Column("DiasDeLocacao")]

        public int DiasDeLocacao { get; set; }
    }
}
