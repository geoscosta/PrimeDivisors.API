using System;
using DivisorLibrary;

namespace TechnicalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterNumber = 0;
            string value = string.Empty;
            bool invalid = true;
            do
            {
                Console.Write("Número de Entrada: ");
                value = Console.ReadLine();
                invalid = !(int.TryParse(value, out enterNumber) && enterNumber > 1);

                if (invalid)
                    Console.WriteLine("Digite valor válido!");
            }
            while (invalid);       

            var result = Divisor.GetPrimesAndDivisorsNumbers(new DivisorParameter(enterNumber));

            Console.Write("Números divisores: ");
            for (int i = 0; i < result.Divisors.Count; i++)
            {
                Console.Write(result.Divisors[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Divisores Primos: ");
            for (int i = 0; i < result.Primes.Count; i++)
            {
                Console.Write(result.Primes[i] + " ");
            }
        }
    }
}
