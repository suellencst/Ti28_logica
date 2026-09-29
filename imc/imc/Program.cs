using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultura = CultureInfo.InvariantCulture;

            Console.Write("Digite o peso em kg (ex: 70.5): ");
            double peso = double.Parse(Console.ReadLine(), cultura);

            Console.Write("Digite a altura em metros (ex: 1.75): ");
            double altura = double.Parse(Console.ReadLine(), cultura);

            double imc = peso / (altura * altura);

            Console.WriteLine($"\nSeu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Condição: Peso ideal (parabéns)");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("Condição: Levemente acima do peso");
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("Condição: Obesidade grau I");
            }
            else if (imc <= 39.9)
            {
                Console.WriteLine("Condição: Obesidade grau II (severa)");
            }
            else
            {
                Console.WriteLine("Condição: Obesidade grau III (mórbida)");
            }

        }
    }
}
