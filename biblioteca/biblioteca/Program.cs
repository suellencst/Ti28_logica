

using System;

using System.Threading;

namespace SistemaBiblioteca

{

    internal class Livro

    {

        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string ISBN { get; set; }

        public int AnoPublicacao { get; set; }

        public string Genero { get; set; }

        public int QuantidadeExemplares { get; set; }

    }


    internal class Jogo

    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public int FaixaEtaria { get; set; }

        public int NumMinJogadores { get; set; }

        public int NumMaxJogadores { get; set; }

        public int QuantidadeExemplares { get; set; }

    }


    internal class Cliente

    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public bool Ativo { get; set; }

    }


    internal class Fornecedor

    {

        public int Id { get; set; }

        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }

    }


    internal class Emprestimo

    {

        public int Id { get; set; }

        public int ClienteId { get; set; }

        public string TipoItem { get; set; }

        public int ItemId { get; set; }

        public DateTime DataEmprestimo { get; set; }

        public DateTime DataDevolucaoPrevista { get; set; }

        public bool Devolvido { get; set; }

    }




    internal class Program

    {

        static void Main(string[] args)

        {

            int opcao = -1;

            while (opcao != 0)

            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(@"

▒█▀▀█ ▀█▀ ▒█▀▀█ ▒█░░░ ▀█▀ ▒█▀▀▀█ ▀▀█▀▀ ▒█▀▀▀ ▒█▀▀█ ░█▀▀█ 
▒█▀▀▄ ▒█░ ▒█▀▀▄ ▒█░░░ ▒█░ ▒█░░▒█ ░▒█░░ ▒█▀▀▀ ▒█░░░ ▒█▄▄█ 
▒█▄▄█ ▄█▄ ▒█▄▄█ ▒█▄▄█ ▄█▄ ▒█▄▄▄█ ░▒█░░ ▒█▄▄▄ ▒█▄▄█ ▒█░▒█ 

");

    Console.ResetColor();

    Console.WriteLine("1 - Cadastrar Livro");

    Console.WriteLine("2 - Cadastrar Jogo");

    Console.WriteLine("3 - Cadastrar Cliente");

    Console.WriteLine("4 - Cadastrar Fornecedor");

    Console.WriteLine("5 - Registrar Empréstimo");

    Console.WriteLine("0 - Sair");

    Console.WriteLine();

    Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)

                {

                    case 1:

                        Cadastro_Livro();

                        break;

                    case 2:

                        Cadastro_Jogo();

                        break;

                    case 3:

                        Cadastro_Cliente();

                        break;

                    case 4:

                        Cadastro_Fornecedor();

                        break;

                    case 5:

                        Registrar_Emprestimo();

                        break;

                    case 0:

                        Console.WriteLine("\nSaindo do sistema...");

                        break;

                    default:

                        Console.WriteLine("\nOpção inválida!");

                        Thread.Sleep(2000);

                        break;

                }

            }

        }


        static void Cadastro_Livro()

        {

            Console.Clear();

            Livro livro = new Livro();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"

█▀▀ █▀▀█ █▀▀▄ █▀▀█ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ 　 █░░ ░▀░ ▀█░█▀ █▀▀█ █▀▀█ 
█░░ █▄▄█ █░░█ █▄▄█ ▀▀█ ░░█░░ █▄▄▀ █░░█ 　 █░░ ▀█▀ ░█▄█░ █▄▄▀ █░░█ 
▀▀▀ ▀░░▀ ▀▀▀░ ▀░░▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀▀▀▀ 　 ▀▀▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀▀▀▀ 

");

            Console.ResetColor();

            Console.Write("Digite o ID do livro: ");

            livro.Id = int.Parse(Console.ReadLine());

            Console.Write("Digite o título: ");

            livro.Titulo = Console.ReadLine();

            Console.Write("Digite o autor: ");

            livro.Autor = Console.ReadLine();

            Console.Write("Digite o ISBN: ");

            livro.ISBN = Console.ReadLine();

            Console.Write("Digite o ano de publicação: ");

            livro.AnoPublicacao = int.Parse(Console.ReadLine());

            Console.Write("Digite o gênero: ");

            livro.Genero = Console.ReadLine();

            Console.Write("Digite a quantidade de exemplares: ");

            livro.QuantidadeExemplares = int.Parse(Console.ReadLine());

            if (livro.QuantidadeExemplares > 0)

            {

                Console.WriteLine("\nLivro disponível!");

            }

            else

            {

                Console.WriteLine("\nLivro indisponível!");

            }

            Console.WriteLine("\nLivro cadastrado com sucesso!");

            Console.WriteLine("Título: " + livro.Titulo);

            Console.WriteLine("Autor: " + livro.Autor);

            Console.WriteLine("ISBN: " + livro.ISBN);

            Console.WriteLine("Ano de publicação: " + livro.AnoPublicacao);

            Console.WriteLine("Gênero: " + livro.Genero);

            Console.WriteLine("Quantidade: " + livro.QuantidadeExemplares);

            Thread.Sleep(5000);

        }


        static void Cadastro_Jogo()

        {

            Console.Clear();

            Jogo jogo = new Jogo();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(@"
 
█▀▀ █▀▀█ █▀▀▄ █▀▀█ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ 　 ░░▀ █▀▀█ █▀▀▀ █▀▀█ 
█░░ █▄▄█ █░░█ █▄▄█ ▀▀█ ░░█░░ █▄▄▀ █░░█ 　 ░░█ █░░█ █░▀█ █░░█ 
▀▀▀ ▀░░▀ ▀▀▀░ ▀░░▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀▀▀▀ 　 █▄█ ▀▀▀▀ ▀▀▀▀ ▀▀▀▀
 
");

            Console.ResetColor();

            Console.Write("Digite o ID do jogo: ");

            jogo.Id = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do jogo: ");

            jogo.Nome = Console.ReadLine();

            Console.Write("Digite a categoria: ");

            jogo.Categoria = Console.ReadLine();

            Console.Write("Digite a faixa etária: ");

            jogo.FaixaEtaria = int.Parse(Console.ReadLine());

            Console.Write("Digite o número mínimo de jogadores: ");

            jogo.NumMinJogadores = int.Parse(Console.ReadLine());

            Console.Write("Digite o número máximo de jogadores: ");

            jogo.NumMaxJogadores = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de exemplares: ");

            jogo.QuantidadeExemplares = int.Parse(Console.ReadLine());

            if (jogo.QuantidadeExemplares > 0)

            {

                Console.WriteLine("\nJogo disponível!");

            }

            else

            {

                Console.WriteLine("\nJogo indisponível!");

            }

            Console.WriteLine("\nJogo cadastrado com sucesso!");

            Console.WriteLine("Nome: " + jogo.Nome);

            Console.WriteLine("Categoria: " + jogo.Categoria);

            Console.WriteLine("Faixa etária: " + jogo.FaixaEtaria);

            Console.WriteLine("Mínimo de jogadores: " + jogo.NumMinJogadores);

            Console.WriteLine("Máximo de jogadores: " + jogo.NumMaxJogadores);

            Console.WriteLine("Quantidade: " + jogo.QuantidadeExemplares);

            Thread.Sleep(5000);

        }




        static void Cadastro_Cliente()

        {

            Console.Clear();

            Cliente cliente = new Cliente();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"

█▀▀ █▀▀█ █▀▀▄ █▀▀█ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ 　 █▀▀ █░░ ░▀░ █▀▀ █▀▀▄ ▀▀█▀▀ █▀▀ 
█░░ █▄▄█ █░░█ █▄▄█ ▀▀█ ░░█░░ █▄▄▀ █░░█ 　 █░░ █░░ ▀█▀ █▀▀ █░░█ ░░█░░ █▀▀ 
▀▀▀ ▀░░▀ ▀▀▀░ ▀░░▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀▀▀▀ 　 ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀
 
");

            Console.ResetColor();

            Console.Write("Digite o ID do cliente: ");

            cliente.Id = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome: ");

            cliente.Nome = Console.ReadLine();

            Console.Write("Digite o CPF: ");

            cliente.CPF = Console.ReadLine();

            Console.Write("Digite o telefone: ");

            cliente.Telefone = Console.ReadLine();

            Console.Write("Digite o e-mail: ");

            cliente.Email = Console.ReadLine();

            Console.Write("Digite a data de nascimento (dd/MM/yyyy): ");

            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("O cliente está ativo? (s/n): ");

            string resposta = Console.ReadLine().ToLower();

            if (resposta == "s")

            {

                cliente.Ativo = true;

            }

            else

            {

                cliente.Ativo = false;  

            }

            Console.WriteLine("\nCliente cadastrado com sucesso!");

            Console.WriteLine("Nome: " + cliente.Nome);

            Console.WriteLine("CPF: " + cliente.CPF);
             
            Console.WriteLine("Telefone: " + cliente.Telefone);

            Console.WriteLine("E-mail: " + cliente.Email);

            Console.WriteLine("Data de nascimento: " +

                cliente.DataNascimento.ToString("dd/MM/yyyy"));

            Console.WriteLine("Ativo: " + cliente.Ativo);

            Thread.Sleep(5000);

        }


        static void Cadastro_Fornecedor()

        {

            Console.Clear();

            Fornecedor fornecedor = new Fornecedor();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(@"

█▀▀ █▀▀█ █▀▀▄ █▀▀█ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ 　 █▀▀ █▀▀█ █▀▀█ █▀▀▄ █▀▀ █▀▀ █▀▀ █▀▀▄ █▀▀█ █▀▀█ 
█░░ █▄▄█ █░░█ █▄▄█ ▀▀█ ░░█░░ █▄▄▀ █░░█ 　 █▀▀ █░░█ █▄▄▀ █░░█ █▀▀ █░░ █▀▀ █░░█ █░░█ █▄▄▀
▀▀▀ ▀░░▀ ▀▀▀░ ▀░░▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀▀▀▀ 　 ▀░░ ▀▀▀▀ ▀░▀▀ ▀░░▀ ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀░ ▀▀▀▀ ▀░▀▀
 
 
");

            Console.ResetColor();

            Console.Write("Digite o ID do fornecedor: ");

            fornecedor.Id = int.Parse(Console.ReadLine());

            Console.Write("Digite a razão social: ");

            fornecedor.RazaoSocial = Console.ReadLine();

            Console.Write("Digite o CNPJ: ");

            fornecedor.CNPJ = Console.ReadLine();

            Console.Write("Digite o telefone: ");

            fornecedor.Telefone = Console.ReadLine();

            Console.Write("Digite o e-mail: ");

            fornecedor.Email = Console.ReadLine();

            Console.Write("Digite o endereço: ");

            fornecedor.Endereco = Console.ReadLine();

            if (fornecedor.RazaoSocial != "")

            {

                Console.WriteLine("\nFornecedor identificado!");

            }

            else

            {

                Console.WriteLine("\nRazão social não informada!");

            }

            Console.WriteLine("\nFornecedor cadastrado com sucesso!");

            Console.WriteLine("Razão Social: " + fornecedor.RazaoSocial);

            Console.WriteLine("CNPJ: " + fornecedor.CNPJ);

            Console.WriteLine("Telefone: " + fornecedor.Telefone);

            Console.WriteLine("E-mail: " + fornecedor.Email);

            Console.WriteLine("Endereço: " + fornecedor.Endereco);

            Thread.Sleep(5000);

        }


        static void Registrar_Emprestimo()

        {

            Console.Clear();

            Emprestimo emprestimo = new Emprestimo();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(@"
 
█▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀█ 　 █▀▀ █▀▄▀█ █▀▀█ █▀▀█ █▀▀ █▀▀ ▀▀█▀▀ ░▀░ █▀▄▀█ █▀▀█
█▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █░░█ 　 █▀▀ █░▀░█ █░░█ █▄▄▀ █▀▀ ▀▀█ ░░█░░ ▀█▀ █░▀░█ █░░█ 
▀░▀▀ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀▀▀▀ 　 ▀▀▀ ▀░░░▀ █▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀▀▀ ▀░░░▀ ▀▀▀▀
 
");

            Console.ResetColor();

            Console.Write("Digite o ID do empréstimo: ");

            emprestimo.Id = int.Parse(Console.ReadLine());

            Console.Write("Digite o ID do cliente: ");

            emprestimo.ClienteId = int.Parse(Console.ReadLine());

            Console.Write("Digite o tipo do item (Livro/Jogo): ");

            emprestimo.TipoItem = Console.ReadLine();

            Console.Write("Digite o ID do livro ou jogo: ");

            emprestimo.ItemId = int.Parse(Console.ReadLine());

            emprestimo.DataEmprestimo = DateTime.Now;

            Console.Write("Digite a data prevista para devolução (dd/MM/yyyy): ");

            emprestimo.DataDevolucaoPrevista =

                DateTime.Parse(Console.ReadLine());

            Console.Write("O item já foi devolvido? (s/n): ");

            string resposta = Console.ReadLine().ToLower();

            if (resposta == "s")

            {

                emprestimo.Devolvido = true;

            }

            else

            {

                emprestimo.Devolvido = false;

            }

            Console.WriteLine("\nEmpréstimo registrado com sucesso!");

            Console.WriteLine("Cliente ID: " + emprestimo.ClienteId);

            Console.WriteLine("Tipo do item: " + emprestimo.TipoItem);

            Console.WriteLine("Item ID: " + emprestimo.ItemId);

            Console.WriteLine("Data do empréstimo: " +

                emprestimo.DataEmprestimo);

            Console.WriteLine("Data prevista: " +

                emprestimo.DataDevolucaoPrevista.ToString("dd/MM/yyyy"));

            Console.WriteLine("Devolvido: " + emprestimo.Devolvido);

            Thread.Sleep(5000);

        }

    }

}


