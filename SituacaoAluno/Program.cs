using System;

class SituacaoAluno
{
    static void Main(string[] args)
    {
        double n1, n2, n3, n4, media;
        string nome, situacao;

        Console.WriteLine("Aluno digite seu primeira NOME: ");
        nome = Console.ReadLine();

        Console.WriteLine(nome+" digite sua primeira NOTA: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(nome + " digite sua primeira NOTA: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(nome + " digite sua terceia NOTA: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(nome + " digite sua quarta NOTA: ");
        n4 = Convert.ToDouble(Console.ReadLine());

        // Calcular a média final do aluno
        media = (n1 + n2 + n3 + n4) / 4;


        //Determinar se o aluno está aprovado ou reprovado
        //Para ser aprovado a nota de ser maior ou igual a 7
        if (media >= 7)
        {
            Console.WriteLine(nome + " PARABÉNS você está APROVADO, sua media é "+ media);
        }
        else         {
            Console.WriteLine(nome + " você está REPROVADO, sua média é "+media );
        }

        Console.WriteLine(nome + " precione o Enter duas vezes para sair do sistema!");
        Console.ReadLine();
        

    }
}
