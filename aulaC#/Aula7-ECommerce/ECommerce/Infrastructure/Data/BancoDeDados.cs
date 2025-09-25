using ECommerce.Domain.Entities;

namespace ECommerce.Infrastructure.Data;

public static class BancoDeDados
{
    public static List<Pedido> Pedidos { get; set; } = new();
    public static List<Cliente> Clientes { get; set;} = new();
    public static List<Produto> Produtos { get; set; } = new();
}
