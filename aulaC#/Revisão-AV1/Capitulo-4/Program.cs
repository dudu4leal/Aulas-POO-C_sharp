
using Capitulo_4;

List<Funcionario> ListaDeFuncionario = new List<Funcionario>();

while (true)
{
    Console.WriteLine("Salário do funcionário CLT: ");
    double salarioCLT = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Salário do funcionário FreeLancer por hora: ");
    double salarioFLH = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Quantas horas ele trabalhou?: ");
    int horasTrab = Convert.ToInt32(Console.ReadLine());

    FuncionarioCLT funcionarioClt = new FuncionarioCLT(salarioCLT);
    FuncionarioFreeLancer funcionarioFreeLancer = new FuncionarioFreeLancer(horasTrab, salarioFLH);

    ListaDeFuncionario.Add(funcionarioClt);
    ListaDeFuncionario.Add(funcionarioFreeLancer);

    Console.WriteLine("Deseja adicionar mais funcionários? [S/N]");
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
        break;
    }
}


foreach (Funcionario funcionario in ListaDeFuncionario)
{
    funcionario.CalcularSalario();
    Console.WriteLine();
}