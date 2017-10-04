using System;
using System.Globalization;

namespace exemplo_produto {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            p.nome = Console.ReadLine();
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.quant = int.Parse(Console.ReadLine());

            double total = p.total();

            Console.WriteLine("Valor total de " + p.nome 
                + ": " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
