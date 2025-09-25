using static ECommerce.Domain.Helpers.Utilitarios;
using ECommerce.Domain.Entities;
using ECommerce.Application.Services;

namespace ECommerce.Presentation;

public static class ClienteIncluir
{
    public static void Incluir()
    {
        while (true)
        {
            Clear();
            Print("Inclusao de cliente");
            Print("-------------------\n");

            Cliente cliente = new Cliente();

            cliente.Id = ClienteService.Listar().Count + 1;

            cliente.Nome = Input("Nome: ");

            cliente.Endereco = Input("Endereco: ");

            ClienteService.Incluir(cliente);

            string resposta = Input("Deseja incluir outro (S/N)?: ");

            if (resposta.Trim().ToLower() != "s")
                break;
        }
    }

    public static void Listar()
    {
        Clear();

        Print("\nListagem de clientes");
        Print("---------------------\n");

        foreach (Cliente cliente in ClienteService.Listar())
        {
            Print($"ID: {cliente.Id:D6} | NOME: {cliente.Nome} | ENDERECO: {cliente.Endereco}");
        }

        PrintInLine("\nPressione qualquer tecla...");
        Console.ReadKey();
    }

    public static void Excluir()
    {
        Listar();

        int IdExcluir = Input("Digite o ID do cliente que deseja excluir: ");
        foreach (Cliente cliente in ClienteService.Listar())
        {
            if (cliente.Id == IdExcluir)
            {
                ClienteService.Excluir();
                Print($"{cliente.Nome} excluido com exito!!");
                break;
            }
        }
    }
}
