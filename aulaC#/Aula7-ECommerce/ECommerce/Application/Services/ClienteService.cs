using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Data;

namespace ECommerce.Application.Services;

public static class ClienteService
{
    public static void Incluir(Cliente cliente)
    {
        if (cliente.Nome.Contains("Andre"))
        {
            throw new Exception("Caloteiro!");
        }
        
        BancoDeDados.Clientes.Add(cliente);
    }

    public static void Excluir(Cliente cliente)
    {
        BancoDeDados.Clientes.RemoveAt(cliente.Id - 1);
        Reorganizar();
    }

    public static List<Cliente> Listar()
    {
        return BancoDeDados.Clientes.ToList();
    }

    public static void Reorganizar()
    {
        int contador = 0;
        foreach (Cliente cliente in Listar())
        {
            cliente.Id = contador+1;
            contador++;
        }
    }
}
