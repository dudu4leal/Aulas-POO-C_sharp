namespace ECommerce.Infrastructure;

public class CLienteRepository
{
    public static void Incluir(Cliente cliente)
    {
        BancoDeDados.Clientes.Add(cliente);
    }

    public static void Excluir(Cliente cliente)
    {
        Cliente? clienteNoBanco = BancoDeDados
        .Clientes
        .Find(p => p.Id == id);

        if (clienteNoBanco != null)
        {
            BancoDeDados.Clientes.Remove(clienteNoBanco);
        }
    }

    public static List<Cliente> Listar()
    {
        return BancoDeDados.ToList();
    }

    public static void Alterar(CLienteRepository cliente)
    {
        cliente? clienteNoBanco = BancoDeDados
        .Clientes
        .find(p => p.Id == id);

        if (clienteNoBanco != null)
        {
            clienteNoBanco = cliente;
        }    
    }
}
