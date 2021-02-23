using System;

namespace Ex004 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite Três Números: ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int x, int y, int z) {
            int m;
            
            if (x > y && x > z) {
                m = x;
            } else if (y > z) {
                m = y;
            } else {
                m = z;
            }

            return m;
        }
    }
}
