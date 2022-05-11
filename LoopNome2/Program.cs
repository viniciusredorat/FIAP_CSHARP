using System;

class LoopNome2
{
    static void Main(string[] args)
    {
        string nome;
        int repeticao;

        Console.WriteLine("Digito seu nome");
        nome = Console.ReadLine();

        Console.WriteLine("Quantas repetições");
        repeticao = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        while (count < repeticao)
        {
            //Console.WriteLine(count + " - " + nome);
            Console.WriteLine("Essa é a volta contador {0}, eu me chamo {1}", count, nome) ;
            count++;
        }

        Console.WriteLine("FIM!!!")
    }
}
