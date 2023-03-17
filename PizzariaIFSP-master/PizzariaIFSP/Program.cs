using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaIFSP
{
    internal class Program
    {
        static int Menu()
        {
            Console.WriteLine("SAIR ------ 0");
            Console.WriteLine("CADASTRAR - 1");
            Console.WriteLine("LISTAR ---- 2");
            Console.WriteLine("EDITAR ---- 3");
            Console.WriteLine("REMOVER --- 4");
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int qtd = 0, opcao;
            Cliente[] vetCli = new Cliente[100];
            do {
                opcao = Menu();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Tchau!");
                        break;
                    case 1:
                        Console.WriteLine("Nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Telefone: ");
                        telefone = Console.ReadLine();
                        Console.WriteLine("Quer preencher e-mail " +
                            "e data de nascimento? 1 - Sim ou 0 - Não");
                        int escolha = int.Parse(Console.ReadLine());
                        if (escolha == 1)
                        {
                            Console.WriteLine("Email: ");
                            string email = Console.ReadLine();
                            Console.WriteLine("Data de nascimento: ");
                            DateTime nasc = Convert.ToDateTime(Console.ReadLine());
                            vetCli[qtd++] = new Cliente(
                                qtd, nome, telefone, email, nasc);
                        }
                        else
                        {
                            vetCli[qtd++] = new Cliente(
                                qtd, nome, telefone);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < qtd; i++)
                        {
                            Console.WriteLine(vetCli[i].ToString());
                        }
                        break;
                        
                    case 3:
                        Console.Write("Entre com o telefone");
                        telefone = Console.ReadLine();
                        for(int i = 0; i < qtd; i++)
                        {
                            if(vetCli[i].Telefone == telefone)
                            {
                                int op;
                                do
                                {
                                    Console.WriteLine("Este são os dados do cliente:\n");
                                    Console.WriteLine("Nome:"+ vetCli[i].Nome);
                                    Console.WriteLine("Telefone:"+ vetCli[i].Telefone);
                                    Console.WriteLine("Email:"+ vetCli[i].Email);
                                    Console.WriteLine("Data Nascimento:"+ vetCli[i].DatNasc);
                                    Console.WriteLine("----------------------------");
                                    Console.WriteLine("     Editar Nome ------------ 1");
                                    Console.WriteLine("     Editar Telefone -------- 2");
                                    Console.WriteLine("     Editar Email ----------- 3");
                                    Console.WriteLine("     Editar Data Nascimento - 4");
                                    Console.WriteLine("     Sair da Edição --------- 0");
                                    switch (op)
                                    {
                                        case 0:
                                            Console.WriteLine("Cadastro atualizado!")
                                        case 1:
                                            Console.WriteLine("Nome: ");
                                            vetCli[i].Nome = Console.ReadLine();
                                            break;
                                        case 1:
                                            Console.Write.Line("Nome: ");
                                            vetCli[i].Telefone = Console.ReadLine();
                                            break;
                                        case 1:
                                            Console.Write.Line("Nome: ");
                                            vetCli[i].Email = Console.ReadLine();
                                            break;
                                        case 1:
                                            Console.Write.Line("Nome: ");
                                            vetCli[i].DatNasc = Console.ReadLine();
                                            break;
                                        default:
                                            Console.WriteLine("Opção invalida!\nCliente não atualizado!");
                                            break;
                                    }
                                }while (op != 0);
                                break;
                            }   
                        }
                        break;
                    case 4:
                        Console.WriteLine("Digite o número de telefone: ");
                        string tel = Console.ReadLine();
                        for (int i = 0; i < qtd; i++)
                        {
                            if (vetCli[i].telefone == tel)
                            {
                                vetCli[i] = vetCli[qtd - 1];
                                qtd--;
                                break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);


            Console.ReadKey();
        }
    }
}
