using System.Dynamic;

namespace aula4
{
    public class Curador : Jogador
    {
        public Curador(string nome) : base(nome)
        {

        }

        public new void Curar(int impacto, Jogador jogadorCurado)
        {
            
            base.Curar(impacto, jogadorCurado);
            
        }

    }
}
