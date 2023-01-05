using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace locacaoProjeto.Models
{

    [Table("Pedidos")]
    public class Pedido
    {

        [Display(Name = "Código")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Código_Cliente")]
        [Column("Id_Cliente")]
        public int ClienteId { get; set; }

        [Display(Name = "Carro")]
        [Column("Carro")]
        public string? Carro { get; set; }

        [Display(Name = "Data de Locação")]
        [Column("DataDeLocacao")]
        public DateTime DataLocacao { get; set; }

        [Display(Name = "Data de Entrega")]
        [Column("DataDeEntrega")]
        public DateTime DataEntrega { get; set; }
    }
}
