namespace Models.Pedido;

public class Pedido{

    public int Id { get; set; }
    public int Idcliente { get; set; }
    public string? Carro { get; set; }
    public DateTime DataLocacao { get; set; }
    public DateTime DataEntrega { get; set; }

}