using System;
using System.Globalization;

namespace ExPropostos005
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler o código de uma peça 1, 
            // o número de peças 1, o valor unitário d ecada peça 1, 
            // o código de uma peça 2, o número de peça 2 e valor 
            // unitário de cada peça 2. Calcule e mostre o valor a ser pago.

            Console.WriteLine("Dados:");
            string[] productOne = Console.ReadLine().Split(" ");

            string[] productTwo = Console.ReadLine().Split(" ");

            double value = ((int.Parse(productOne[1]) * double.Parse(productOne[2])) + (int.Parse(productTwo[1]) * double.Parse(productTwo[2])));

            Console.WriteLine("Produto 1: {0} {1} {2}", productOne[0], productOne[1], double.Parse(productOne[2]).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Produto 2: {0} {1} {2}", productTwo[0], productTwo[1], double.Parse(productTwo[2]).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor a Pagar: {0}", value.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
