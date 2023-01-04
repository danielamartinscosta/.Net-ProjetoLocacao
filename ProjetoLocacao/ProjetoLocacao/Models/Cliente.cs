using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoLocacao.Models
{

    [Table("Clientes")]
    public class Cliente
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código")]
        [Column("Id")]
        public int ClienteId { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string? Email { get; set; }

        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public string? Telefone { get; set; }

        [Display(Name = "Endereco")]
        [Column("Endereco")]
        public string? Endereco { get; set; }
    }
}
