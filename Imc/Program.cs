using System;

class ProgramImc
{
    static void Main(string[] args)
    {
        int peso;
        double altura, imc;
        string nome, classificacao;

        Console.WriteLine("Digite seu NOME");
        nome = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Digite seu PESO");
        peso = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite sua ALTURA");
        altura = Convert.ToDouble(Console.ReadLine());

        //Calculo do IMC
        imc = peso / (altura * altura);

        //Determinar a classificação do cliente/paciente
        if (imc < 18.5)
        {
            classificacao = "Abaixo do peso!";
        }
        else if (imc >= 18.6 && imc <= 24.9)
        {
            classificacao = "Peso Ideal (PARABÉNS)!";
        }
        else if (imc >= 25.0 && imc <= 29.9)
        {
            classificacao = "Levemente acima do peso!";
        }
        else if (imc >= 30.0 && imc <= 34.9)
        {
            classificacao = "Obesidade grau I!";
        }
        else if (imc >= 35.0 && imc <= 39.9)
        {
            classificacao = "Obesidade grau II!";
        }
        else
        {

            classificacao = "Obesidade grau III (mórbidade)!";
        }

        Console.WriteLine();
        Console.WriteLine(nome + " seu IMC é: " + imc);
        Console.WriteLine("Sua classificação de IMC é **** " + classificacao+ " ****");
        Console.WriteLine();
    
    }

}