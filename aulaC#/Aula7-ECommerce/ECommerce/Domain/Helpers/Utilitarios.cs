namespace ECommerce.Domain.Helpers;
public static class Utilitarios
{
    public static void Print(string texto)
    {
        Console.WriteLine(texto);
    }

    public static void PrintInLine(string texto)
    {
        Console.Write(texto);
    }

    public static string Input(string mensagem = "")
    {
        if (mensagem != "")
        {
            PrintInLine(mensagem);
        }
        return Console.ReadLine();
    }

    public static void Clear()
    {
        Console.Clear();
    }
}
