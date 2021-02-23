using System;

namespace ExPropostos001
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um Programa para ler dois valores inteiros, 
            // e depois mostrar na tela a soma desses números com 
            // uma mensagem explicativa, conforme os exemplos.

            int n1 = int.Parse(Console.ReadLine());

            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: " + (n1 + n2));
        }
    }
}
