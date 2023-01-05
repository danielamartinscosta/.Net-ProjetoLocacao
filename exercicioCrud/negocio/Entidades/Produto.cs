
namespace Negocio.Entidades;


public record Produto  //record é indicado para classes pequenas
{
    public int Id { get; set; }
    public string? Nome { get; set; } = default!;
    public string? Descricao { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataValidade { get; set; }
    public int QuantidadeEstoque { get; set; }

}