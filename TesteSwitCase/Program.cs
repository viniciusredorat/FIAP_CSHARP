using System;

class TesteSwitCase
{
    static void Main (string[] args)
    {
        Console.WriteLine("Jogo JOKEPON");
        Console.WriteLine();
        Console.WriteLine("[1] - Pedra");
        Console.WriteLine("[2] - Papel");
        Console.WriteLine("[3] - Tesoura");
        Console.WriteLine();
        Console.WriteLine("Qual sua escolha ?");

        escolhaJogador = Convert.ToInt32(Console.ReadLine());

        int escolhaJogador = new Random().Next(1,4);

        switch (escolhaJogador)
        {
            case 1:
                Console.WriteLine("O jogador escolhou PEDRA");

                switch (escolhaJogador)
                {
                    case 1:

                        Console.WriteLine("O jogador escolhou PEDRA");
                        Console.WriteLine("O jogador empatou");
                    break;

                   case 2:
                         Console.WriteLine("O jogador escolhou PAPEL");
                       Console.WriteLine("O computador VENCEU");
                   break;

                     case 3:
                        Console.WriteLine("O jogador escolhou TESOURA");
                       Console.WriteLine("O jogador VENCEU");
                       break;
                 }

                break;

            case 2:
                Console.WriteLine("O computador escolhou PAPEL");

                switch (escolhaJogador)
                {
                    case 1:

                        Console.WriteLine("O computador escolhou PAPEL");
                        Console.WriteLine("O jogador empatou");
                        break;

                    case 2:
                        Console.WriteLine("O computador escolhou PEDRA");
                        Console.WriteLine("O jogador VENCEU");
                        break;

                    case 3:
                        Console.WriteLine("O computador escolhou TESOURA");
                        Console.WriteLine("O computador VENCEU");
                        break;
                }

            case 3:
                Console.WriteLine("O computador escolhou TESOURA");

                switch (escolhaJogador)
                {
                    case 1:

                        Console.WriteLine("O computador escolhou PEDRA");
                        Console.WriteLine("O computador empatou");
                        break;

                    case 2:
                        Console.WriteLine("O computador escolhou PAPEL");
                        Console.WriteLine("O jogador VENCEU");
                        break;

                    case 3:
                        Console.WriteLine("O computador escolhou TESOURA");
                        Console.WriteLine("O JOGO VENCEU");
                        break;
                }
                break;
                Console.WriteLine("Opção Incorreta");
                break;
        }


        
    }
}
