using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podologo
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
    
                int opcao = 0;

                do
                {



                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"

 ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ 
 █▀▀ █░░ ░▀░ █▀▀▄ ░▀░ █▀▀ █▀▀█ 　 █▀▀▄ █▀▀ 　 █▀▀█ █▀▀█ █▀▀▄ █▀▀█ █░░ █▀▀█ █▀▀▀ ░▀░ █▀▀█ 　 ░░
 █░░ █░░ ▀█▀ █░░█ ▀█▀ █░░ █▄▄█ 　 █░░█ █▀▀ 　 █░░█ █░░█ █░░█ █░░█ █░░ █░░█ █░▀█ ▀█▀ █▄▄█ 　 ▀▀ 
 ▀▀▀ ▀▀▀ ▀▀▀ ▀░░▀ ▀▀▀ ▀▀▀ ▀░░▀ 　 ▀▀▀░ ▀▀▀ 　 █▀▀▀ ▀▀▀▀ ▀▀▀░ ▀▀▀▀ ▀▀▀ ▀▀▀▀ ▀▀▀▀ ▀▀▀ ▀░░▀ 　 ░ 　 
    
 █▀▀█ ▀▀█▀▀ █▀▀ █▀▀▄ █▀▀▄ ░▀░ █▀▄▀█ █▀▀ █▀▀▄ ▀▀█▀▀ █▀▀█ █▀▀ 
 █▄▄█ ░░█░░ █▀▀ █░░█ █░░█ ▀█▀ █░▀░█ █▀▀ █░░█ ░░█░░ █░░█ ▀▀█ 
 ▀░░▀ ░░▀░░ ▀▀▀ ▀░░▀ ▀▀▀░ ▀▀▀ ▀░░░▀ ▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀▀ ▀▀▀ 
 ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ 
");
                    Console.ResetColor();
                    Console.WriteLine("1 - Cadastrar cliente");
                    Console.WriteLine("2 - Cadastrar Podólogo");
                    Console.WriteLine("3 - Cadastrar procedimento/servico");
                    Console.WriteLine("4 - Agendar consulta");
                    Console.WriteLine("5 - Listar agendamentos");
                    Console.WriteLine("6 - Exibir Todos os cadastros");
                    Console.WriteLine("0 - Sair");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@" ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓ ▓▓");

                    Console.WriteLine("Edcolha uma opção: ");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                { 

       
                         case 1:

                                int idcliente;
                                string nomecliente;
                                string cpfcliente;
                                string telefonecliente;
                                DateTime datanascimentoCliente;
                                bool possuidiabetes;
                                string observacoesAnamnese;

                                Console.Clear();

                                Console.WriteLine("Cadastrar cliente");
                                Console.WriteLine();

                                Console.WriteLine("Digite o ID do cliente: ");
                                idcliente = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o nome completo: ");
                                nomecliente = Console.ReadLine();

                                Console.WriteLine("Digite o CPF: ");
                                cpfcliente = Console.ReadLine();

                                Console.WriteLine("Digite o telefone: ");
                                telefonecliente = Console.ReadLine();

                                Console.Write("Possui diabetes? (s/n): ");
                                string diabetes = Console.ReadLine().ToLower();

                                if (diabetes == "s")
                                {
                                    possuidiabetes = true;
                                }
                                else
                                {
                                    possuidiabetes = false;
                                }
                                Console.WriteLine("Digite as observações da anamnse: ");
                                observacoesAnamnese = Console.ReadLine();

                                Console.WriteLine();
                                Console.WriteLine("Cliente cadastro com sucesso!");

                                break;

                            case 2:

                                int idpodologo;
                                string nomepodologo;
                                string registroprofissional;
                                string especialidade;
                                string telefonepodologo;

                                Console.Clear();

                                Console.WriteLine("Cadastro podologo");
                                Console.WriteLine();

                                Console.WriteLine("Digite o ID do podologo: ");
                                nomepodologo = Console.ReadLine();

                                Console.WriteLine("Digite o registro profissional: ");
                                registroprofissional = Console.ReadLine();

                                Console.WriteLine("Digite a especialidade: ");
                                especialidade = Console.ReadLine();

                                Console.WriteLine("Digite o telefone: ");
                                telefonepodologo = Console.ReadLine();

                                break;

                            case 3:
                                int idprocedimento;
                                string nomeprocedimento;
                                int duracaominutos;
                                decimal valor;

                                Console.WriteLine("Cadastrar o procedimento: ");
                                Console.WriteLine();

                                Console.WriteLine("Digite o ID do procedimento: ");
                                nomecliente = Console.ReadLine();

                                Console.WriteLine("Digite a duracao em minutos: ");
                                duracaominutos = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o valor: R$ ");
                                valor = decimal.Parse(Console.ReadLine());

                                Console.WriteLine();
                                Console.WriteLine("Procedimento cadastro com sucesso");

                                break;

                            case 4:

                                int idagendamento;
                                int clienteid;
                                int procedimentoid;
                                DateTime datahora;
                                string status;


                                Console.Clear();

                                Console.WriteLine("Agendar consulta ");
                                idagendamento = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o ID do cliente: ");
                                clienteid = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite ID do podologo: ");
                                procedimentoid = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite a hora e data (dd/mm/yyyy): ");
                                datahora = DateTime.Parse(Console.ReadLine());

                                status = "Agendado";

                                Console.WriteLine();
                                Console.WriteLine("Agendamento realizado com sucesso!");

                                break;

                            case 5:

                                Console.Clear();

                                Console.WriteLine("Todos Os Cadastros: ");
                                Console.WriteLine();

                                Console.WriteLine("Os cadastros serao exobidos aqui.");

                                break;


                            case 0:

                                Console.WriteLine();
                                Console.WriteLine("Saindo do sistema... ");

                                break;

                            default:

                                Console.WriteLine();
                                Console.WriteLine("Opcao invalida!");

                                break;

                        }
                        if (opcao != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine(
                                "Pressione ENTER para continuar...");
                            Console.ReadLine();
                        }

                    } while (opcao != 0);

                }

            }

        }


    

