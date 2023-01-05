using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace locacaoProjeto.Models
{

    [Table ("Carros")]
    public class Carro
    {
        [Display(Name ="Código")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }

        [Display(Name = "Marca")]
        [Column("MarcaId")]
        public int MarcaId { get; set; }

        [Display(Name = "Modelo")]
        [Column("ModeloId")]
        public int ModeloId { get; set; }
    }
}
