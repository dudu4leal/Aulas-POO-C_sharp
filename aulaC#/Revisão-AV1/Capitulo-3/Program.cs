using Capitulo_3;



Console.WriteLine("Nome do aluno: ");
string nomeAluno = Console.ReadLine();

Console.WriteLine("Matricula do aluno");
int numeroMatricula = Convert.ToInt32(Console.ReadLine());

Aluno aluno = new Aluno(nomeAluno, numeroMatricula);

Matricula matricula = new Matricula(aluno);

Console.WriteLine("Em quais disciplinas vai se matricular?");

while (true)
{
    Console.WriteLine("Nome da disciplina: ");
    string nomeDisciplina = Console.ReadLine();

    Console.WriteLine($"Carga horária de {nomeDisciplina}: ");
    int cargaHoraria = Convert.ToInt32(Console.ReadLine());

    Disciplina disciplina = new Disciplina(nomeDisciplina, cargaHoraria);

    matricula.Disciplinas.Add(disciplina);

    Console.WriteLine("Mais uma? [S/N]");
    string condicao = Console.ReadLine();
    condicao = condicao.ToUpper();

    while (condicao != "S" && condicao != "N")
    {
        Console.WriteLine("Condição inválida. Digite novamente: ");
        condicao = Console.ReadLine();
        condicao = condicao.ToUpper();
    }

    if (condicao == "N")
    {
        matricula.ExibirResumo();
        break;
    }
}





