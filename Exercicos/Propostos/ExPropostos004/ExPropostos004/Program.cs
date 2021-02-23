using System;

namespace ExPropostos004
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa que leiao número de um funcionário,
            // seu número de horas trabalhadas, o valor que recebe 
            // por hora e calcula o salario desse funcionário.
            // A seguir, mostre o número e o salário do funcionário, 
            // com duas casas decimais.

            Console.Write("Id: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Hours: ");
            double hours = double.Parse(Console.ReadLine());

            Console.Write("Value per hour: ");
            double value = double.Parse(Console.ReadLine());

            double salary = hours * value;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary + ",00");
        }
    }
}
