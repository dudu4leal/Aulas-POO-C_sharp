namespace Capitulo_3;

public class Aluno
{
    public string Nome { get; set; }

    public int Matricula { get; set; }

    public Aluno(string nome, int matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }

}
