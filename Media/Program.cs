using System;

class Media
{
    static void Main(string[] args)
    {
        double n1, n2, n3, media;
        string  nome;

        //n1 = 7.3;
        //n2 = 8.2;
        //n3 = 6.3;
        //media = (n1+n2+n3)/3;
        //Console.WriteLine( "Aluno digite seu nome para saber a média de sua nota:"  );
        //Console.ReadLine();
        //Console.WriteLine(media);

        

        Console.WriteLine("Aluno digite seu nome para saber a média de sua nota:");
        nome = Console.ReadLine();

        Console.WriteLine(nome + " Digite sua primeira nota");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(nome + " Digite sua segunda nota");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(nome + " Digite sua segunda nota");
        n3 = Convert.ToDouble(Console.ReadLine());

        media = (n1 + n2 + n3) / 3;
        if (imc >= 35)
        {
            situacao = 
        }

        Console.WriteLine(nome + " sua média é: " + media);

    } 
}
