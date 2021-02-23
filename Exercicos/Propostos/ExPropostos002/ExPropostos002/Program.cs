using System;
using System.Globalization;

namespace ExPropostos002
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa para ler o valor do raio de um circulo,
            // e depois mostrar o valor da área deste círculo com quatro
            // casas decimais conforme os exemplos.

            // A = π . r2 Formula para realizar tal calculo

            double raio = double.Parse(Console.ReadLine());

            double area = 3.14159 * (raio * raio);

            Console.WriteLine("O circulo que contem o raio igual a {0} tem sua área igual a: {1}", raio, area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
