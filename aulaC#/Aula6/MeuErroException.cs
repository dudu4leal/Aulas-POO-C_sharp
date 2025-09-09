namespace Aula6;

public class MeuErroException : Exception
{

    public MeuErroException()
    {
        
    }

    public MeuErroException(string mensagem) : base(mensagem)
    {

    }

    public MeuErroException(string mensagem, Exception excecao) : base(mensagem, excecao)
    {

    }





}
