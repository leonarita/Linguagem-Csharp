using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Compras
{
    class Program
    {
        static void Main(String[] args)
        {
            double total, valorCompra;
            float pagCartao, moeda;

            Console.WriteLine("Insira o valor da compra: ");
            valorCompra = Convert.ToDouble(Console.ReadLine());

            total = (valorCompra + 0.5) * 5;

            Console.WriteLine("Valor retornado: " + System.Math.Round(total, 4, 0));
            Console.ReadLine();
        }
    }
}