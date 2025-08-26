
namespace aula2.models
{
    public class PedidoItem
    {

        public int Id { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }


        public void Print()
        {

            Console.WriteLine("Item");
            Console.WriteLine(Id);
            Console.WriteLine(Quantidade);
            Console.WriteLine(Preco);

        }

    }


}