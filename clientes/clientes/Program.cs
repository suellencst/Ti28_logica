using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Desenvolva um programa que armazene o histórico de compras de 10 clientes
            // e mostre o total gasto por cada cliente

            double[,] compras = new double[10, 3];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Cliente{i + 1}");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite o valor {j + 1}da compra: R$ ");
                    compras[i, j] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine();
            }

            Console.WriteLine("Total gasto por cliente: ");

            for (int i = 0; i < 10; i++)
            {
                double totalCliente = 0;

                for (int j = 0; j < 3; j++)
                {
                    totalCliente += compras[i, j]; // Soma as compras da linha do cliente
                }

                Console.WriteLine($"Cliente {i + 1}: R$ {totalCliente:F2}");
            }
        }
    }
}





