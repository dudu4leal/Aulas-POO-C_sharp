namespace Revisão_AV1;

public class Aluno
{

    public Aluno(string nome, double nota1, double nota2)
    {
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
    }



    public string Nome { get; set; }

    public double Nota1 { get; private set; }

    public double Nota2 { get; private set; }

    public double CalcularMedia()
    {
        double media = (Nota1 + Nota2) / 2;

        return media;
    }

    public void ExibirMedia()
    {
        Console.WriteLine($"Aluno: {Nome} - Média: {CalcularMedia()}");
    }
}
