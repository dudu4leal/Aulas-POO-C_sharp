namespace Aula6;



Console.WriteLine("Digite o primeiro numero: ");
decimal numero1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
decimal numero2 = Convert.ToDecimal(Console.ReadLine());

try
{
    if (numero2 == 0)
        throw new MeuErroException("O segundo número tem que ser diferente de zero.");

    Console.WriteLine($"O resultado é {numero1 / numero2}");
}
catch (MeuErroException erro)
{
    Console.WriteLine($"Erro customizado | {erro.Message}");
}
catch (DivideByZeroException erro)
{
    Console.WriteLine($"Erro de divisão por zero | {erro.Message}");
}
catch (ArgumentNullException erro)
{
    Console.WriteLine($"Valor nulo digitado | {erro.Message}");
}
catch (Exception erro)
{
    Console.WriteLine($"Ocorreu um erro desconhecido | {erro.Message}");
}
finally
{
    Console.WriteLine("\nExecução finalizada (bloco finally).");
}

Console.ReadLine();