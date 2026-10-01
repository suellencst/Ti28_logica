using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frutas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implemente um sistema que armazene as quantidades de 5 tipos de frutas em 3 cestas
            //calcule o total de frutas de cadatipo 

            string[] frutas = { "Maçãs", "Bananas", "Pêras", "Laranjas", "Uvas" };

            int[,] cestas = new int[3, 5];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Cesta {i + 1}");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Quantidade de {frutas[j]}: ");
                    cestas[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Total de frutas por tipo: ");

            for (int j = 0; j < 5; j++)
            {
                int totalTipo = 0;

                for (int i = 0; i < 3; i++)

                {
                    totalTipo += cestas[i, j];
                }

                Console.WriteLine($"{frutas[j]}: {totalTipo}");
            }
            }
        }
    }