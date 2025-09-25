namespace Capitulo_4;

public class FuncionarioFreeLancer : Funcionario
{
    public int HorasTrabalhadas { get; set; }

    public double ValorPorHora { get; set; }


    public FuncionarioFreeLancer(int horasTrabalhadas, double valorPorHora)
    {
        HorasTrabalhadas = horasTrabalhadas;
        ValorPorHora = valorPorHora;
    }


    public override void CalcularSalario()
    {
        double salario = HorasTrabalhadas * ValorPorHora;

        Console.WriteLine($"Salário do funcionário freelancer é: R${salario}");
    }
}
