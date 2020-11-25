using System;

namespace Exercicios_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (var num1 = 1; num1 < 10; num1++)
            {
                Console.WriteLine($"Tabuada do {num1}");
                for (var num2 = 1; num2 < 11; num2++)
                {
                    int resultado = num1*num2;
                    Console.WriteLine(resultado);
                    Console.WriteLine("");

                }
            }
            
        }
    }
}
