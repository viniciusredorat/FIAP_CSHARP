using System;

class Par_ou_Impar
{
    static void Main (string[] args)
    {
        string nome;
        int numero, contador = 0;

        Console.WriteLine("Digite seu nome");
        nome = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine(nome + " Digie um valor inteiro");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        while (contador <= numero)
        {
            if (contador % 2 == 0)
            {
                Console.WriteLine("{0} é par", contador);
            }
            else
            {
                Console.WriteLine("{0} é impar", contador);
            }
            contador++;           
        } 
    }
}