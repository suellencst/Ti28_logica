using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        bool valor1, valor2;

        Console.Write("Digite o primeiro valor (true/false): ");
        valor1 = bool.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor (true/false): ");
        valor2 = bool.Parse(Console.ReadLine());

        if (valor1 == true && valor2 == true)
        {
            Console.WriteLine("Ambos são VERDADEIROS.");
        }
        else if (valor1 == false && valor2 == false)
        {
            Console.WriteLine("Ambos são FALSOS.");
        }
        else
        {
            Console.WriteLine("Um é VERDADEIRO e o outro é FALSO.");
        }
    }
} 