﻿using System;
using System.Globalization;

namespace ex004
{
    class Program {

        static double Pi = 3.14;
        static void Main(string[] args) {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circuferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: " + Pi);
        }

        static double Circuferencia(double r) {
            return 2.0 * Pi * r;
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r;
        }
    }
}
