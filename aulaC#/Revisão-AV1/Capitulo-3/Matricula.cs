namespace Capitulo_3;

public class Matricula
{
    public Aluno Aluno { get; private set; }

    public List<Disciplina> Disciplinas { get; private set; }

    public Matricula(Aluno aluno)
    {
        Aluno = aluno;
        Disciplinas = new List<Disciplina>();
    }


    public void ExibirResumo()
    {

        Console.WriteLine("\n==RESUMO DA MATRÍCULA==\n");

        Console.WriteLine($"Aluno: {Aluno.Nome}\n");

        Console.WriteLine("Disciplinas matriculadas: ");

        foreach (Disciplina disciplina in Disciplinas)
        {
            Console.WriteLine($"- {disciplina.Nome} | Carga horária: {disciplina.CargaHoraria}");
        }
    }
}
