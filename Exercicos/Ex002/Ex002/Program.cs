using System;
using System.Globalization;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());

            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você Digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine("Soma de n1 + n2 = " + (n1 + n2));
            Console.WriteLine(n3.ToString("F2", CultureInfo.InvariantCulture));

            // Maria F 23 1.68

            string[] vet = Console.ReadLine().Split(" ");

            string nome = vet[0];

            char sexo = char.Parse(vet[1]);

            int idade = int.Parse(vet[2]);

            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);

            Console.WriteLine(sexo);

            Console.WriteLine(idade);

            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
