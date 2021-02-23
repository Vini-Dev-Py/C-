using System;

namespace Ex003 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual a hora atual ?");
            int x = int.Parse(Console.ReadLine());

            if (x < 12) {
                Console.WriteLine("Bom dia");
            } else if (x < 18) {
                Console.WriteLine("Boa Tarde");
            } else { // ou else if (x >= 18) {}
                Console.WriteLine("Boa Noite");
            }

            int value = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("Par !");
            } else {
                Console.WriteLine("Impar !");
            }
        }
    }
}
