using System;

namespace ExPropostos003
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler quatro valores interios A, B, C, D. 
            // A seguir, calcule e mostre a difereça do produto de A e B pelo
            // produto de C e D segundo a fórmula: DIFERENÇA = (A * B - C * D).

            Console.WriteLine("Informe 4 Números: Exemplo 5 6 7 8");

            string[] vet = Console.ReadLine().Split(" ");

            int a = int.Parse(vet[0]);

            int b = int.Parse(vet[1]);

            int c = int.Parse(vet[2]);

            int d = int.Parse(vet[3]);

            Console.WriteLine("DIFERENÇA = " + ((a * b) - (c * d)));

            // Testando uma ideia um tanto quanto diferente : ) espero que gostem !

            Console.WriteLine("Informe 4 Números: Exemplo 5 6 7 8");

            Console.WriteLine("DIFERENÇA = " + ((int.Parse(vet[0]) * int.Parse(vet[1])) - (int.Parse(vet[2]) * int.Parse(vet[3])))); // Desse modo não precisamos criar 4 variaveis !

        }
    }
}
