
using aula4;
using static aula4.Util;

JogadorAmigo amigo = new("Batman");

JogadorInimigo inimigo = new("Coringa");

Random rnd = new();

Curador anjo = new("Anjo");

while (true)
{

    //Rodada do amigo atacar
    Print($"\nRodada do  {amigo.Tipo}, o {amigo.Nome}");

    int impacto = rnd.Next(20);
    inimigo.TomaAtaque(impacto);

    Print($"O {amigo.Nome} aplicou {impacto} de dano no {inimigo.Nome}");

    //Verificando se o jogador atacado receberá cura
    int sorte = rnd.Next(2);

    if (sorte == 1)
    {
        anjo.Curar(7, inimigo);
        Print($"O jogador {inimigo.Nome} recebu 7 de cura\n");
    }
    else
    {
        Print($"O jogador {inimigo.Nome} não recebeu cura\n");
    }


    //Rodada do inimigo atacar
    Print($"Rodada do  {inimigo.Tipo}, o {inimigo.Nome}");

    impacto = rnd.Next(20);
    amigo.TomaAtaque(impacto);

    Print($"O {inimigo.Nome} aplicou {impacto} de dano no {amigo.Nome}");


    //Verificando se o jogador atacado receberá cura
    sorte = rnd.Next(2);

    if (sorte == 1)
    {
        anjo.Curar(7, amigo);
        Print($"O jogador {amigo.Nome} recebu 7 de cura");
    }
    else
    {
        Print($"O jogador {amigo.Nome} não recebeu cura\n");   
    }

    //Mostrando quantas vidas cada jogador tem
    Print($"Vida do {amigo.Nome}: {amigo.Vida}");
    Print($"Vida do {inimigo.Nome}: {inimigo.Vida}");

    //Verificando se o jogo acabou
    if (amigo.Vida == 0)
    {
        Print($"\nO {amigo.Nome} se fodeu");
        break;
    }

    if (inimigo.Vida == 0)
    {
        Print($"\nO {inimigo.Nome} se fodeu");
        break;
    }

    //Caso o jogo não tenha acabado, pressiona enter pra continuar
    Print("\nPressione enter para a próxima rodada");
    Input();
    Print("");

}
