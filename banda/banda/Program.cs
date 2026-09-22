using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cadastro_de_Bandas
{
    internal class Program
    {
        /*
         
         Se  /  enquanto  / para / caso

        if       while      for      switch


        Crie um sistema de Cadastro de Álbuns de um artista / banda que sera possível cadastrar um numero X 
        de músicas informada pelo usuário. Crie um menu de opções para isso. */

        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 4)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(@"

░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝


██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine(" 1 - Cadastrar Album da Banda");

                Console.WriteLine(" 2 - Cadastrar Album do Artista");

                Console.WriteLine(" 3 - Cadastrar Músicas");

                Console.WriteLine(" 4 - Sair do Programa");

                Console.WriteLine(" ----> ");

                Console.ResetColor();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Cadastro_Bandas();

                        break;

                    case 2:

                        Cadastro_Album();

                        break;

                    case 3:

                        Cadastro_Musicas();

                        break;

                    case 4:

                        Console.WriteLine(" Saindo do Programa!!! Tchau Tchau !!    :)");

                        break;

                    default:

                        Console.WriteLine("Opção inválida!");

                        Thread.Sleep(2000);

                        break;
                }
            }
        }


        static void Cadastro_Bandas()
        {
            string nomeBanda, nomeAlbum;

            int qtdMusicas;

            Console.Clear();

            Console.WriteLine(@"

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝


██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Digite o Nome da Banda:");

            nomeBanda = Console.ReadLine();

            Console.WriteLine("Digite o Nome da Album:");

            nomeAlbum = Console.ReadLine();

            Console.WriteLine("Digite o Número de Músicas:");

            qtdMusicas = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCadastro realizado com Sucesso !!!");

            Console.WriteLine($"\nNome da Banda: {nomeBanda}");

            Console.WriteLine($"\nNome do Album: {nomeAlbum}");

            Console.WriteLine($"\nQuantidade de Músicas: {qtdMusicas}");

            Console.ResetColor();

            Thread.Sleep(5000);
        }


        static void Cadastro_Album()
        {
            // Ano, Nome Artista, qtd album, qtd vendas

            int qtdAlbum, qtdVendas, Ano;

            string nomeArtista;

            Console.Clear();

            Console.WriteLine(@"

▄▀█ █░░ █▄▄ █░█ █▀▄▀█   █▀▄ █▀█   ▄▀█ █▀█ ▀█▀ █ █▀ ▀█▀ ▄▀█
█▀█ █▄▄ █▄█ █▄█ █░▀░█   █▄▀ █▄█   █▀█ █▀▄ ░█░ █ ▄█ ░█░ █▀█");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Digite o Ano do Album:");

            Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do artista:");

            nomeArtista = Console.ReadLine();

            Console.WriteLine("Quantidade de Album:");

            qtdAlbum = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de vendas:");

            qtdVendas = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAno do album: " + Ano);

            Console.WriteLine("\nNome do Artista: " + nomeArtista);

            Console.WriteLine("\nQuantidade de Album: " + qtdAlbum);

            Console.WriteLine("\nQuantidade de Vendas: " + qtdVendas);

            Console.ResetColor();

            Thread.Sleep(5000);
        }


        static void Cadastro_Musicas()
        {
            string nomeMusica;

            int duracao;

            string premiacao;

            int qtdMusicas;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(@"

        ██████╗ █████╗ ██████╗  █████╗ ███████╗████████╗██████╗  ██████╗
        ██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗
        ██║     ███████║██║  ██║███████║███████╗   ██║   ██████╔╝██║   ██║
        ██║     ██╔══██║██║  ██║██╔══██║╚════██║   ██║   ██╔══██╗██║   ██║
        ╚██████╗██║  ██║██████╔╝██║  ██║███████║   ██║   ██║  ██║╚██████╔╝
         ╚═════╝╚═╝  ╚═╝╚═════╝ ╚═╝  ╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝

        ███╗   ███╗██╗   ██╗███████╗██╗ ██████╗ █████╗ ███████╗
        ████╗ ████║██║   ██║██╔════╝██║██╔════╝██╔══██╗██╔════╝
        ██╔████╔██║██║   ██║███████╗██║██║     ███████║███████╗
        ██║╚██╔╝██║██║   ██║╚════██║██║██║     ██╔══██║╚════██║
        ██║ ╚═╝ ██║╚██████╔╝███████║██║╚██████╗██║  ██║███████║
        ╚═╝     ╚═╝ ╚═════╝ ╚══════╝╚═╝ ╚═════╝╚═╝  ╚═╝╚══════╝
");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Digite a quantidade de músicas:");

            qtdMusicas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdMusicas; i++)
            {
                Console.WriteLine($"\n--- Música {i} ---");

                Console.WriteLine("Digite o nome da música:");

                nomeMusica = Console.ReadLine();

                Console.WriteLine("Digite a duração da música em minutos:");

                duracao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a premiação da música:");

                premiacao = Console.ReadLine();

                Console.WriteLine("\nMúsica cadastrada com sucesso!");

                Console.WriteLine($"Nome: {nomeMusica}");

                Console.WriteLine($"Duração: {duracao} minutos");

                Console.WriteLine($"Premiação: {premiacao}");
            }

            Console.ResetColor();

            Console.WriteLine("\nTodas as músicas foram cadastradas com sucesso!!!");

            Thread.Sleep(5000);
        }
    }
}
