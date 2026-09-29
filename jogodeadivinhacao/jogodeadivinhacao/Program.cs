using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogodeadivinhacao
{
    internal class Program
    {
        //Simular o jogo de adivinhação: o jogador 1 escolhe um número entre 1 e 10;
        // o jogador 2 insere números na tentativa de acertar o número escolhido pelo jogador 1
        // Quando ele acertar, o algoritmo deve informar que ele acertou o número x 
        //(escolhido pelo jogador 1) em x tentativas (quantidade de tentativas do jogador  2).


        static void Main(string[] args)
        {
            int numero;
            int tentativa;
            int tentativas = 0;

            Console.WriteLine("Jogador 1, escolha um número entre 1 e 10: ");
            numero = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Jogador 2, tente adivinha o número: ");

            do
            {
                Console.WriteLine("Digite sua tentativa: ");
                tentativa = int.Parse(Console.ReadLine());

                tentativa++;

                if (tentativa != numero)
                {
                    Console.WriteLine("Você errou! Tente novamente.");
                }


            } while (tentativa != numero);
            {
                Console.WriteLine("Parabéns! Você acertou o número " + numero);
                Console.WriteLine("Quantidade de tentativas: " + tentativas);

                Console.ReadKey();
            }




        }
    }
}
