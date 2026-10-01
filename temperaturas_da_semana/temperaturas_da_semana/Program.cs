using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperaturas_da_semana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crie um algoritmo que armazene as temperatura diarias de uma cidade
            // e informe o dia mais quente e o mais frio

            double[] temperatura = new double[7];
            string[] dias =
            {
                "domingo", "segunda", "terça", "quarta", "quinta", "sexta", "sábado"
            };

            for (int dia = 0; dia < 7; dia++)
            {
                Console.Write("Digite a temperatura de " + dias[dia] + ": ");
                temperatura[dia] = double.Parse(Console.ReadLine());
            }

            int diamaisquente = 0;
            int diamaisfrio = 0;
            for (int dia = 1; dia < 7; dia++)
            {
                if (temperatura[dia] > temperatura[diamaisquente])
                {
                    diamaisquente = dia;
                }
                if (temperatura[dia] < temperatura[diamaisfrio])
                {
                    diamaisfrio = dia;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Resultado");

            Console.WriteLine("Dia mai quente: " + dias[diamaisquente] + " - " + temperatura[diamaisquente].ToString("F1") + "°C");

            Console.WriteLine("Dia mais frio: " + dias[diamaisfrio] + " - " + temperatura[diamaisfrio].ToString("F1") + "°C");

        

            Console.ReadKey();

        }
    }
}
