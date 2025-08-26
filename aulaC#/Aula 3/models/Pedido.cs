
using System.Dynamic;

namespace aula2.models
{
    public class Pedido
    {

        public int Id { get; set; }

        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; } = new();

        public PedidoItem PedidoItem { get; set; } = new();

        public List<PedidoItem> PedidoItens { get; set; } = new();

        public void Print()
        {

            Console.WriteLine("---------------");
            Console.WriteLine("Dados do pedido");
            Console.WriteLine("---------------");
            Console.WriteLine("ID do pedido: " + Id);
            Console.WriteLine("Data do pedido: " + Data);
            Cliente.Print();

            foreach (PedidoItem pi in PedidoItens)
            {
                pi.Print();
            }



        }

    }


}