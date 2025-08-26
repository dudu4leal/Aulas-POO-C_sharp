using System.Dynamic;

namespace aula4
{
    public class JogadorAmigo : Jogador
    {
        public JogadorAmigo(string nome) : base(nome)
        {

        }

        public string Tipo { get; private set; } = "Amigo";


    }
}
