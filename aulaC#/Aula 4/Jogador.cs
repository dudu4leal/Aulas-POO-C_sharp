using System.Dynamic;

namespace aula4
{
    public class Jogador
    {

        public Jogador(string nome)
        {
            Nome = nome;
        }


        public string Nome { get; set; }

        public int Vida { get; private set; } = 100;


        public void TomaAtaque(int impacto)
        {

            Vida -= impacto;
            if (Vida < 0)
            {
                Vida = 0;
            }
            else if (Vida > 100)
            {
                Vida = 100;
            }

        }

        protected void Curar(int impacto, Jogador jogador)
        {
            jogador.Vida += impacto;
            if (jogador.Vida > 100) jogador.Vida = 100;
        }

    }
}
