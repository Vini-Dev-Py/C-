﻿using System;
using System.Globalization;

namespace Ex003 {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removidos: ");
            int rem = int.Parse(Console.ReadLine());
            p.RemoverProdutos(rem);

            Console.WriteLine("Dados atualizados do produto: " + p);
        }
    }
}
