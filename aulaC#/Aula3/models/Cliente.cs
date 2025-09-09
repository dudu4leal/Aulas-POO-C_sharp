
namespace aula2.models
{
    public class Cliente
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public void Print()
        {
            Console.WriteLine("-------");
            Console.WriteLine("Cliente");
            Console.WriteLine("-------");
            Console.WriteLine("ID do cliente: " + Id);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF/CNPJ: "+ CNPJ);
        } 

    }


}