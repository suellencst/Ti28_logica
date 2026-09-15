using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisão
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2;

            Console.Write("Digite seu numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("A divisão do numero é igual à: " + ((double)n1 / n2));



        }
    }
}
