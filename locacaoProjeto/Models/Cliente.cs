using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace locacaoProjeto.Models
{

    [Table("Clientes")]
    public class Cliente
    {

        [Display(Name = "Código")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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
