using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Estoque_vinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // construa um programa que permita fazer o levantamento de estoque de vinho de uma adega, tendo como dados de entrada
            // tipos de video, sendo: "t" para tinto e "b" para branco. como a quantidade de vinhos é desconhecida, utilize a letra "f"
            // para finalizar. apos finalizar o programa deve mostrar a quantidade de cada vinho.

            int tinto = 0;
            int branco = 0;
            string tipo;

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(@"


        ░█▀▀█ █▀▀▄ █▀▀ █▀▀▀ █▀▀█ 　 █▀▀▄ █▀▀ 　 ▀█░█▀ ░▀░ █▀▀▄ █░░█ █▀▀█ █▀▀ 
        ▒█▄▄█ █░░█ █▀▀ █░▀█ █▄▄█ 　 █░░█ █▀▀ 　 ░█▄█░ ▀█▀ █░░█ █▀▀█ █░░█ ▀▀█ 
        ▒█░▒█ ▀▀▀░ ▀▀▀ ▀▀▀▀ ▀░░▀ 　 ▀▀▀░ ▀▀▀ 　 ░░▀░░ ▀▀▀ ▀░░▀ ▀░░▀ ▀▀▀▀ ▀▀▀ ");



            
            Console.ResetColor();

            Console.WriteLine("Digite o tipo de vinho: ");
            Console.WriteLine("T = Tinto");
            Console.WriteLine("B = Branco");
            Console.WriteLine("F = Finalizar");

            tipo = Console.ReadLine().ToLower();



            while (tipo != "f")
            {
                if (tipo == "t") 
                {
                    tinto++;
                }
                else if (tipo == "b")
                {
                    branco++;
                }
                else
                {
                    Console.WriteLine("Tipo inválido!");
                }

                tipo = Console.ReadLine().ToLower();

            }

            Console.WriteLine("Quantidade de vinhos tintos: " + tinto);
            Console.WriteLine("Quantidade de vinhos brancos: " +  branco);




        }
    }
}
