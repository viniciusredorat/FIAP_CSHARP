using System;

    class Jogo
{
    static void Main(string[] args)
    {
        Random random = new Random(); //gerar número aleatórios (sorteia números inteiros ou pontos flutuantes
    
        string nomeJogador_1, nomeJogador_2;
        int vlJogador1, vlJogador2;

        Console.WriteLine("Jogador 1 digite seu primiero nome: ");
        nomeJogador_1 = Console.ReadLine();

        Console.WriteLine("Jogador 2 digite seu primiero nome: ");
        nomeJogador_2 = Console.ReadLine();

        Console.WriteLine("****************************");
        Console.WriteLine("****** J O K E N P O *******");
        Console.WriteLine("****************************");
        Console.WriteLine("* ----  REGRA DO JOGO ---- *");
        Console.WriteLine("* Pedra   GANHA DE Tesoura *");
        Console.WriteLine("* Papel   GANHA DE Pedra   *");
        Console.WriteLine("* Tesoura GANHA DE Papel   *");
        Console.WriteLine("****************************");
        Console.WriteLine();
        Console.WriteLine("****************************");
        Console.WriteLine("* -------   OPÇÕES ------  *");
        Console.WriteLine("* [ 1 ] - Pedra            *");
        Console.WriteLine("* [ 2 ] - Papel            *");
        Console.WriteLine("* [ 3 ] - Tesoura          *");
        Console.WriteLine("****************************");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(nomeJogador_1 + " escolha uma das opções acima");
        vlJogador1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine(nomeJogador_2 + " escolha uma das opções acima");
        vlJogador2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(random.Next(61));

        if (vlJogador1 > 0 && vlJogador1 < 4 && vlJogador2 > 0 && vlJogador2 < 4)
        {
           if (vlJogador1 == vlJogador2)
                {
                    Console.WriteLine("Jogo Empatou");
                }
            else
            {
                if ((vlJogador1 == 1 && vlJogador2 == 3) || (vlJogador1 == 2 && vlJogador2 == 1) || (vlJogador1 == 3 && vlJogador2 == 2))
                {
                    Console.WriteLine(nomeJogador_1 + " VOCÊ FOI O CAMPEÃO");
                }
                else
                {
                   Console.WriteLine(nomeJogador_2 + " VOCÊ FOI O CAMPEÃO");
                }
            }
        }
        else
        {
            Console.WriteLine("Jogada Inválida!!!");
        }

        Console.ReadLine();
    }
}

