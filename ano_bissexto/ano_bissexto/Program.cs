using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ano_bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6. Ano bissexto
            // Determine se um ano é bissexto. Um ano é bissexto se for divisível por 4, mas não por 100
            // a não ser que seja divisível por 400
            // entrada: 2024
            // sáida esperada: Ano bissexto

            int ano = 2024;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(@"

        ░█▀▀█ █▀▀▄ █▀▀█ 　 █▀▀▄ ░▀░ █▀▀ █▀▀ █▀▀ █░█ ▀▀█▀▀ █▀▀█ 
        ▒█▄▄█ █░░█ █░░█ 　 █▀▀▄ ▀█▀ ▀▀█ ▀▀█ █▀▀ ▄▀▄ ░░█░░ █░░█ 
        ▒█░▒█ ▀░░▀ ▀▀▀▀ 　 ▀▀▀░ ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀ ▀░▀ ░░▀░░ ▀▀▀▀ 


");




            Console.ResetColor();






            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0) {
                Console.WriteLine("Ano bissexto");

            }
            else
            {
                Console.WriteLine("Ano não bissexto");
            }



        }
    }
}
