using System;

class loopNome
{
    static void Main(string[] args)
    {
        int x = 5;
        int y = 5;

        Console.WriteLine(x++); //o ++ apos o x ele soma ,sendo que o x sera 5, ´pq a soma é apos o valor do x
        Console.WriteLine(x);   // soma o valor do x para 1, que sera 6
        Console.WriteLine();


        Console.WriteLine(++y); //o ++ antes do y sera soma  ele somas, endo que o x sera 5, ´pq a soma é antes o valor do x
        Console.WriteLine(y);   // soma o valor do x para 1, que sera 6
        Console.WriteLine();
    }
}