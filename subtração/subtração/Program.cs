using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtração
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, number2, soma;

            Console.WriteLine("Digite o primeiro número: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            soma = number - number2;

            Console.WriteLine("O rasultado da subtração é: " + soma); 

        }
    }
}
