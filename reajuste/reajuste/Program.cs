using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reajuste
{
    internal class Program
    {
        //faça um algoritmo que leia um valor qualquer e imprima na tela
        //com um reajuste de 5%
        static void Main(string[] args)
        {
            double valor, reajuste, resultado;

            Console.WriteLine("Digite um valor: ");
            valor = double.Parse(Console.ReadLine());

            reajuste = valor * 0.05;
            resultado = valor + reajuste;

            Console.WriteLine("Valor com reajuste de 5%: R$ " +  resultado.ToString("F2"));

            




        }
    }
}
