// See htusing System;

class Jogo
{
    static void Main(string[] args)
    {
        Random random = new Random(); //gerar número aleatórios (sorteia números inteiros ou pontos flutuantes

        Console.WriteLine(random.Next(61)); //quando é informado o valor dentro do parentes ele sortei ate o numero que esta no parentes, mas, não sortei o valor que esta no parentes
        Console.WriteLine(random.Next(10, 15)); //qunado esta com dois valores, ele sorteia qualquer numero inteiro entre 10 e 15. Desta forma pode entrar o 10 o valor 15 nunca será sorteado
        Console.WriteLine(random.Next(61));
        Console.WriteLine(random.Next(61));
        Console.WriteLine(random.Next(61));
        Console.WriteLine(random.Next(61));
        Console.WriteLine(random.Next(61));
        Console.WriteLine(random.Next(61));
        Console.WriteLine(random.Next(61));
        Console.WriteLine(random.Next(61));

    }

}