namespace ECommerce.Domain.Entities;

public class Pedido
{
    public int Id { get; set; }

    public Cliente Cliente { get; set; } = new Cliente();

    public int ClienteId { get; set; }

    public List<Produto> Produtos { get; set; } = new();
}
