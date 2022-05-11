using System;

class Situacao_FrequenciaAluno
{
    static void Main (string[] args)
    {
        double n1, n2, n3, n4, mediaNota, percFrenquecia, qtdaAula, qtdaFaltas;
        string nomeAl, nomePr, situacao;

        Console.WriteLine("Aluno digite seu primeira NOME: ");
        nomeAl = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(nomeAl + " digite sua primeira NOTA: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(nomeAl + " digite sua primeira NOTA: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(nomeAl + " digite sua terceia NOTA: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(nomeAl + " digite sua quarta NOTA: ");
        n4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Professor digite nome");
        nomePr = Console.ReadLine();

        Console.WriteLine("Professor "+nomePr+" digite a quantidade de AULAS da sua disciplina:");
        qtdaAula = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Professor " + nomePr + " digite a quantidade de FALTAS que o aluno " + nomeAl + " teve em sua disciplina:");
        qtdaFaltas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        // Calcular a média final do aluno
        mediaNota = (n1 + n2 + n3 + n4) / 4;

        //Porcentagem de falta
        /*percFrenquecia = qtdaFaltas / qtdaAula * 100;*/
        //Calcular a porcentagem da frequencia
        percFrenquecia = 100-(qtdaFaltas / qtdaAula * 100);


        //Determinar se o aluno está aprovado ou reprovado
        //Para ser aprovado a nota de ser maior ou igual a 7
        if (mediaNota >= 7 && percFrenquecia >= 70)
        {
            Console.WriteLine(nomeAl + " PARABÉNS você está APROVADO!!!");
            Console.WriteLine(nomeAl + " sua MÉDIA é " + mediaNota);
            Console.WriteLine(nomeAl + " sua MÉDIA é FREQUENCIA é " + percFrenquecia + "%");
        }
        else
        {
            Console.WriteLine(nomeAl + " você está REPROVADO!!!");
            Console.WriteLine(nomeAl + " sua MÉDIA é " + mediaNota);
            Console.WriteLine(nomeAl + " sua MÉDIA é FREQUENCIA é " + percFrenquecia +"%");
        }

        Console.WriteLine(nomeAl + " precione o Enter duas vezes para sair do sistema!");
        Console.ReadLine();
    }
}