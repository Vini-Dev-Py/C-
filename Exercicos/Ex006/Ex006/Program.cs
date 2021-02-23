using System;

namespace Ex006 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos Números inteiros você vai digitar ?");

            int N = int.Parse(Console.ReadLine());


            int soma = Somar(N);

            Console.WriteLine("Soma = {0}", soma);

        }

        static int Somar(int N) {

            int soma = 0;

            for (int i = 1; i <= N; i++) {
                Console.Write("Valor #{0}: ", i);
                int number = int.Parse(Console.ReadLine());

                soma += number;

            }

            return soma;
        }
    }
}
