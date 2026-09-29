using System;
using System.Collections.Generic;

namespace Hospital
{
    public class Paciente
    {
        public int Id;
        public string Nome;
        public string CPF;
        public DateTime DataNascimento;
        public string TipoSanguineo;
        public string Alergias;
        public string ContatoEmergencia;
    }

    public class Medico
    {
        public int Id;
        public string Nome;
        public string CRM;
        public string Especialidade;
        public string Telefone;
    }

    public class Leito
    {
        public int Id;
        public string NumeroQuarto;
        public string Tipo;
        public bool EstaOcupado; 
    }

    public class Internacao
    {
        public int Id;
        public int PacienteId;       
        public int MedicoResponsavelId;  
        public int LeitoId;             
        public DateTime DataEntrada;     
        public DateTime? DataAlta;      
        public string DiagnosticoEntrada;
        public string Status;
    }

    internal class Program
    {
 
        static List<Paciente> listaPacientes = new List<Paciente>();
        static List<Medico> listaMedicos = new List<Medico>();
        static List<Leito> listaLeitos = new List<Leito>();
        static List<Internacao> listaInternacoes = new List<Internacao>();

        static void Main(string[] args)
        {
            int opcao = 0;

            do
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@" 

        ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██

        ▒█▀▀▀█ ░▀░ █▀▀ ▀▀█▀▀ █▀▀ █▀▄▀█ █▀▀█    ▒█░▒█ █▀▀█ █▀▀ █▀▀█ ░▀░ ▀▀█▀▀ █▀▀█ █░░ █▀▀█ █▀▀█
        ░▀▀▀▄▄ ▀█▀ ▀▀█ ░░█░░ █▀▀ █░▀░█ █▄▄█    ▒█▀▀█ █░░█ ▀▀█ █░░█ ▀█▀ ░░█░░ █▄▄█ █░░ █▄▄█ █▄▄▀
        ▒█▄▄▄█ ▀▀▀ ▀▀▀ ░░▀░░ ▀▀▀ ▀░░░▀ ▀░░▀    ▒█░▒█ ▀▀▀▀ ▀▀▀ █▀▀▀ ▀▀▀ ░░▀░░ ▀░░▀ ▀▀▀ ▀░░▀ ▀░▀▀ 

        ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██ ██
            ");
                Console.ResetColor();

                Console.WriteLine("1 - Cadastrar Paciente");
                Console.WriteLine("2 - Cadastrar Médico");
                Console.WriteLine("3 - Cadastrar Leito");
                Console.WriteLine("4 - Registrar Internação");
                Console.WriteLine("5 - Dar Alta Hospitalar");
                Console.WriteLine("6 - Listar pacientes internados");
                Console.WriteLine("7 - Exibir relatório geral");
                Console.WriteLine("0 - Sair");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("==================================================");
                Console.ResetColor();

                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = -1;
                }

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Cadastrar Paciente\n");

                        Paciente p = new Paciente();

                        Console.Write("Digite o ID do paciente: ");
                        p.Id = int.Parse(Console.ReadLine());

                        Console.Write("Digite o nome completo: ");
                        p.Nome = Console.ReadLine();

                        Console.Write("Digite o CPF: ");
                        p.CPF = Console.ReadLine();

                        Console.Write("Digite a data de nascimento (dd/MM/yyyy): ");
                        p.DataNascimento = DateTime.Parse(Console.ReadLine());

                        Console.Write("Digite o tipo sanguíneo: ");
                        p.TipoSanguineo = Console.ReadLine();

                        Console.Write("Digite as alergias: ");
                        p.Alergias = Console.ReadLine();

                        Console.Write("Digite o contato de emergência: ");
                        p.ContatoEmergencia = Console.ReadLine();

                        listaPacientes.Add(p);

                        Console.WriteLine("\nPaciente cadastrado com sucesso!");
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Cadastrar Médico\n");

                        Medico m = new Medico();

                        Console.Write("Digite o ID do médico: ");
                        m.Id = int.Parse(Console.ReadLine());

                        Console.Write("Digite o nome do médico: ");
                        m.Nome = Console.ReadLine();

                        Console.Write("Digite o CRM: ");
                        m.CRM = Console.ReadLine();

                        Console.Write("Digite a especialidade: ");
                        m.Especialidade = Console.ReadLine();

                        Console.Write("Digite o telefone: ");
                        m.Telefone = Console.ReadLine();

                        listaMedicos.Add(m);

                        Console.WriteLine("\nMédico cadastrado com sucesso!");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Cadastrar Leito\n");

                        Leito l = new Leito();

                        Console.Write("Digite o ID do leito: ");
                        l.Id = int.Parse(Console.ReadLine());

                        Console.Write("Digite o número do quarto: ");
                        l.NumeroQuarto = Console.ReadLine();

                        Console.Write("Digite o tipo do leito (Enfermaria, Apartamento, UTI): ");
                        l.Tipo = Console.ReadLine();

                        l.EstaOcupado = false; 

                        listaLeitos.Add(l);

                        Console.WriteLine("\nLeito cadastrado com sucesso!");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Registrar Internação\n");

                        Internacao internacao = new Internacao();

                        Console.Write("Digite o ID da internação: ");
                        internacao.Id = int.Parse(Console.ReadLine());

                        Console.Write("Digite o ID do paciente: ");
                        internacao.PacienteId = int.Parse(Console.ReadLine());

                        Console.Write("Digite o ID do médico responsável: ");
                        internacao.MedicoResponsavelId = int.Parse(Console.ReadLine());

                        Console.Write("Digite o ID do leito: ");
                        internacao.LeitoId = int.Parse(Console.ReadLine());

                        bool leitoEncontrado = false;

                        for (int i = 0; i < listaLeitos.Count; i++)
                        {
                            if (listaLeitos[i].Id == internacao.LeitoId)
                            {
                                leitoEncontrado = true;

                                if (listaLeitos[i].EstaOcupado)
                                {
                                    Console.WriteLine("\nErro: Este leito já está OCUPADO!");
                                    break;
                                }

                                Console.Write("Digite o diagnóstico de entrada: ");
                                internacao.DiagnosticoEntrada = Console.ReadLine();

                                internacao.DataEntrada = DateTime.Now;
                                internacao.DataAlta = null;
                                internacao.Status = "Em Internação";

                                listaLeitos[i].EstaOcupado = true;

                                listaInternacoes.Add(internacao);

                                Console.WriteLine("\nInternação registrada com sucesso!");
                                break;
                            }
                        }

                        if (!leitoEncontrado)
                        {
                            Console.WriteLine("\nErro: Leito não encontrado!");
                        }
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("DAR ALTA HOSPITALAR\n");

                        Console.Write("Digite o ID da internação: ");
                        int idAlta = int.Parse(Console.ReadLine());

                        bool altaEncontrada = false;

                   
                        for (int i = 0; i < listaInternacoes.Count; i++)
                        {
                            if (listaInternacoes[i].Id == idAlta && listaInternacoes[i].Status == "Em Internação")
                            {
                            altaEncontrada = true;

                            listaInternacoes[i].DataAlta = DateTime.Now;
                            listaInternacoes[i].Status = "Alta Concluída";

                                
                                for (int j = 0; j < listaLeitos.Count; j++)
                                {
                                    if (listaLeitos[j].Id == listaInternacoes[i].LeitoId)
                                    {
                                        listaLeitos[j].EstaOcupado = false; 
                                    }
                                }

                                
                                TimeSpan tempoPermanencia = listaInternacoes[i].DataAlta.Value - listaInternacoes[i].DataEntrada;

                                Console.WriteLine("\nAlta realizada com sucesso!");

                                Console.WriteLine("Data de Entrada: " + listaInternacoes[i].DataEntrada.ToString("dd/MM/yyyy HH:mm"));

                                Console.WriteLine("Data de Alta   : " + listaInternacoes[i].DataAlta.Value.ToString("dd/MM/yyyy HH:mm"));

                                Console.WriteLine("Tempo de permanência: " + tempoPermanencia.Days + " dias, " + tempoPermanencia.Hours + " horas e " + tempoPermanencia.Minutes + " minutos.");
                                break;
                            }
                        }

                        if (!altaEncontrada)
                        {
                            Console.WriteLine("\nInternação ativa com esse ID não foi encontrada!");
                        }
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("========== PACIENTES INTERNADOS ==========\n");

                        bool encontrouInternado = false;

                        for (int i = 0; i < listaInternacoes.Count; i++)
                        {
                            if (listaInternacoes[i].Status == "Em Internação")
                            {
                                encontrouInternado = true;

                                string nomePaciente = "Não encontrado";
                                for (int j = 0; j < listaPacientes.Count; j++)
                                {
                                    if (listaPacientes[j].Id == listaInternacoes[i].PacienteId)
                                    {
                                        nomePaciente = listaPacientes[j].Nome;
                                        break;
                                    }
                                }

                                Console.WriteLine("ID Internação : " + listaInternacoes[i].Id);
                                Console.WriteLine("Paciente      : " + nomePaciente + " (ID: " + listaInternacoes[i].PacienteId + ")");
                                Console.WriteLine("Leito ID      : " + listaInternacoes[i].LeitoId);
                                Console.WriteLine("Diagnóstico   : " + listaInternacoes[i].DiagnosticoEntrada);
                                Console.WriteLine("Data Entrada  : " + listaInternacoes[i].DataEntrada.ToString("dd/MM/yyyy HH:mm"));
                                Console.WriteLine("------------------------------------------");
                            }
                        }

                        if (!encontrouInternado)
                        {
                            Console.WriteLine("Nenhum paciente internado no momento.");
                        }
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("========== RELATÓRIO GERAL ==========\n");

                        int leitosOcupados = 0;
                        for (int i = 0; i < listaLeitos.Count; i++)
                        {
                            if (listaLeitos[i].EstaOcupado)
                            {
                                leitosOcupados++;
                            }
                        }

                        Console.WriteLine("Total de pacientes cadastrados: " + listaPacientes.Count);
                        Console.WriteLine("Total de médicos cadastrados  : " + listaMedicos.Count);
                        Console.WriteLine("Total de leitos cadastrados   : " + listaLeitos.Count);
                        Console.WriteLine("Leitos ocupados               : " + leitosOcupados);
                        Console.WriteLine("Leitos livres                 : " + (listaLeitos.Count - leitosOcupados));
                        Console.WriteLine("Total de internações          : " + listaInternacoes.Count);
                        break;

                    case 0:
                        Console.WriteLine("\nSaindo do sistema...");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                }

            } while (opcao != 0);

            }
         }
}