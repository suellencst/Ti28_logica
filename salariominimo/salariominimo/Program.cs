using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salariominimo
{
    //2- faça um algoritmo que leia o valor do salário mínimo e o 
    // valor do salário de um usuário, calcule quantos salários mínimos esse usuário 
    //ganha e imprime na tela o resultado. (Base para o salário minimo r$ 1.518,00)

    internal class Program
    {
        static void Main(string[] args)
        {

        double salarioMinimo = 1518.00;
        double salarioUsuario;

        Console.Write("Digite o seu salário: R$ ");
        salarioUsuario = double.Parse(Console.ReadLine());

        double quantidade = salarioUsuario / salarioMinimo;

        Console.WriteLine($"Você ganha aproximadamente {quantidade:F2} salários mínimos.");



        }
    }
}
