using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_que_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1;

            Console.WriteLine("Digite um número: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            if (n1 > 100)
            {
                Console.WriteLine("Seu número é: " +  n1 + " e el é maior que 100");

            }

            else
            {
                Console.WriteLine("Seu número é: " + n1 + " ele não é maior que 100");
            }





        }
    }
}
