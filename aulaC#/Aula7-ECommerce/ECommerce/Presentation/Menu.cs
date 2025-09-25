using static ECommerce.Domain.Helpers.Utilitarios;
using ECommerce.Domain.Entities;

namespace ECommerce.Presentation;

public static class Menu
{
    public static void Mostrar()
    {
        while (true)
        {
            Clear();
            Print("Inclusao de cliente");
            Print("-------------------");
            Print("\n");
            Print("CLIENTE:");
            Print("1. Incluir");
            Print("2. Remover");
            Print("3. Alterar");
            Print("4. Listar");
            Print("0. Sair");

            string opcao = Input("Ecolha uma opcao: ");
            int opcaoNum = Convert.ToInt32(opcao);

            if (opcaoNum == 1)
                ClienteIncluir.Incluir();
            else if (opcaoNum == 2)
                ClienteIncluir.Excluir();
            else if (opcaoNum == 4)
                ClienteIncluir.Listar();
            else if (opcaoNum == 0)
                break;
        }
    }
}
