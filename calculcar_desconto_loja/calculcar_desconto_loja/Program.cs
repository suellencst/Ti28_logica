using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculcar_desconto_loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calcular desconto um produto com preço acima de 100 reais tem um desconto de 10%, caso contrário, o desconto é de 5%
            // calcule o valor de desconto. entrada: 120. saída esperada 12 reais de desconto

            double preco = 120;
            double desconto;


            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Console.WriteLine(@"


        ▒█▀▀▄ █▀▀ █▀▀ █▀▀ █▀▀█ █▀▀▄ ▀▀█▀▀ █▀▀█ 
        ▒█░▒█ █▀▀ ▀▀█ █░░ █░░█ █░░█ ░░█░░ █░░█ 
        ▒█▄▄▀ ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀▀ 

");




            Console.ResetColor();

           


            if (preco > 100) 
            {
                desconto = preco * 0.10;
            }
            else
            {
                desconto = preco * 0.05;
            }

            Console.WriteLine("O valor do desconto é: R$ " + desconto);


        }
    }
}
