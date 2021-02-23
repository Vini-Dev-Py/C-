using System;
using System.Globalization;

namespace ex001 {
    class Program {
        static void Main(string[] args) {
            /* Sem POO

            Console.WriteLine("Entre com as medidas do triangulo X");

            double xA, xB, xC, yA, yB, yC;

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;

            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;

            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = {0}", areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = {0}", areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            } else if (areaX == areaY) {
                Console.WriteLine("X e Y são iguais");
            } else {
                Console.WriteLine("Maior área: Y");
            }

            */

            // Com POO
            Triangulo x, y;

            x = new Triangulo();

            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2;

            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;

            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = {0}", areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = {0}", areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (areaX == areaY)
            {
                Console.WriteLine("X e Y são iguais");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
