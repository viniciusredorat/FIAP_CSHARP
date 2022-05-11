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
                break;

            case 2:
                Console.WriteLine("O jogador escolhou PAPEL");
                break;

            case 3:
                Console.WriteLine("O jogador escolhou TESOURA");
                break;

            default:
                Console.WriteLine("Opção Incorreta");
                break;
        }


        
    }
}
