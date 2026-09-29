using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uma fabrica tem uma linha de produção capaz de produzir 40 peças/dia. Um funcionário
            // controla a qualidade, cadastrando o número da peça e o seu estado (aprovado ou reprovado)>
            //criar um programa para cadastrar o controle de qualidade e imprimir o total de peças aprovadas e reprovadas
            //no final do dia. 


            int aprovado = 0; 
            int reprovado = 0; 

            for(int i =1; i <= 40; i++)
            {
                string estado;

                Console.WriteLine("Digite o estado da peça: " + i + " (aprovado/reprovado): ");
                estado = Console.ReadLine().ToLower();

                if (estado == "aprovado")
                {
                    aprovado++;
                }
                else if (estado == "reprovado")
                {
                    reprovado++;
                }
                else
                {
                    Console.WriteLine("Estado inválido!");
                    i++;
                }
            }

            Console.WriteLine("\n Resultado do dia");
            Console.WriteLine("Peças aprovadas: " +  aprovado);
            Console.WriteLine("Peças reprovadas: " + reprovado);

            Console.ReadKey();

            



        }
    }
}
