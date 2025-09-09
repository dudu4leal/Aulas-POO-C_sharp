using System.Dynamic;

namespace aula4
{
    public class JogadorInimigo : Jogador
    {
        public JogadorInimigo(string nome) : base(nome)
        {
            
        }

        public string Tipo { get; private set; } = "Inimigo";

    }
}
