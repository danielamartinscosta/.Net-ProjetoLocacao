using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoLocacao.Models
{

    [Table ("Carros")]
    public class Carro
    {
        [Display(Name ="Código")]
        [Column("Id")]
        public int CarroId { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }

        [Display(Name = "Marca")]
        [Column("Marca")]
        public string? Marca { get; set; }

        [Display(Name = "Modelo")]
        [Column("Modelo")]
        public string? Modelo { get; set; }
    }
}
