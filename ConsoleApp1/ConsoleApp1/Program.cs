using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Crie um algoritmo para cadastro  do produto: Código, fabricante, categoria, preço, estoque
    //valor total em estoque

    internal class Program
    {


        static void Main(string[] args)
        {
            string codigo, fabricante, categoria;
            int estoque;
            double preco, total;

            Console.WriteLine("Digite o código: ");
            codigo = Console.ReadLine(); 

            Console.WriteLine("Digite o fabricante: ");
            fabricante = Console.ReadLine();

            Console.WriteLine("Digite a categoria: ");
            categoria = Console.ReadLine();

            Console.WriteLine("Digite o preço: ");
            preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o estoque: ");
            estoque = Convert.ToInt32(Console.ReadLine());

            total = preco * estoque;

            Console.WriteLine("O valor total em estoque é " + total);




        }
    }
}
