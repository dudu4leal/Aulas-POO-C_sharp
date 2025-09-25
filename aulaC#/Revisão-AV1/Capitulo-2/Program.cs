using Revisão_AV1;

Console.WriteLine("Digite o nome do aluno: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite a PRIMEIRA nota do {nome}");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Digite a SEGUNDA nota do {nome}");
double nota2 = Convert.ToDouble(Console.ReadLine());

Aluno aluno = new Aluno(nome, nota1, nota2);

aluno.ExibirMedia();





