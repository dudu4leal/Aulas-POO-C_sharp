namespace Capitulo_4;

public class FuncionarioCLT : Funcionario
{

    public double SalarioFixo { get; set; }

    public FuncionarioCLT(double salarioFixo)
    {
        SalarioFixo = salarioFixo;
    }

    public override void CalcularSalario()
    {
        Console.WriteLine($"O salário do funcionário CLT é: R${SalarioFixo}");
    }
}
