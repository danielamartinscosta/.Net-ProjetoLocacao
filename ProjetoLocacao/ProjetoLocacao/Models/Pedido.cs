using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoLocacao.Models
{

    [Table("Pedidos")]
    public class Pedido
    {

        [Display(Name = "Código")]
        [Column("Id")]
        public int PedidoId { get; set; }

        [Display(Name = "Código_Cliente")]
        [Column("Id_Cliente")]
        public int ClienteId { get; set; }

        [Display(Name = "Carro")]
        [Column("Carro")]
        public string? Carro { get; set; }

        [Display(Name = "Data de Locação")]
        [Column("Data de locacao")]
        public DateTime DataLocacao { get; set; }

        [Display(Name = "Data de Entrega")]
        [Column("Data de Entrega")]
        public DateTime DataEntrega { get; set; }
    }
}
