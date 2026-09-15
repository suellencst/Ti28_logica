using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antecessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, menor, maior;

            Console.WriteLine("Escolha um número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            maior = num1 + 1;
            menor = num1 - 1;
            Console.WriteLine("o antecessor é: " + menor);
            Console.WriteLine(",o sucessor é: " + maior); 

        }
    }
}
