using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nome_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;//variavel cadeia
            int idade;//variavel inteiro
           

            Console.WriteLine("Digite seu nome: "); //escreva

            nome = Console.ReadLine(); //leia

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());//Parse convete o que digitar para inteiro

            Console.WriteLine("Parabéns " + nome + "você acabou de ganhar uma coca-cola!");
            Console.WriteLine("\n Você possui " + idade + "anos, beba mais água!");








        }
    }
}
