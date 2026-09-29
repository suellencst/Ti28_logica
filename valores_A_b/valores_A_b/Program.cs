using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valores_A_b
{
    internal class Program
    {
        //faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B
        //forem igauis, deverá somar os valores, caso contrário, deverá multiplicar A por B.
        //Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e imprimir seu valor na tela.


        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Escreva o valor a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor b: ");
           b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
            }
            else
            {
                c = a * b;
            }

            Console.WriteLine("O valor de C é: " + c);
        }
    }
}
