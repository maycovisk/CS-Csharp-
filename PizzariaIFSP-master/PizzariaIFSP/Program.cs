using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzariaIFSP
{
    internal class Program
    { 
        static Cliente Cadastrar(int id)
        {
            string nome, telefone;  
            Cliente aux;

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
                aux = new Cliente(
                    id, nome, telefone, email, nasc);
                //vetCli[qtd++] = new Cliente(
                //    qtd, nome, telefone, email, nasc);
            }
            else
            {
                aux = new Cliente(
                    id, nome, telefone);
            }
            return aux;
        }

        static Cliente Editar(Cliente cli)
        {
            Console.WriteLine("Pesquise pelo nome: ");
            

            for (int i = 0; i < qtd; i++)
            {

                if (vetCli[i].Nome.Contains(pesquisarNome))
                {
                    int op;
                    do
                    {
                        Console.WriteLine("Estes são os dados do cliente: ");
                        Console.WriteLine(vetCli[i].ToString());
                        Console.WriteLine("======= OPÇÕES =======");
                        Console.WriteLine("    SAIR DA EDIÇÃO - 0");
                        Console.WriteLine("       EDITAR NOME - 1");
                        Console.WriteLine("   EDITAR TELEFONE - 2");
                        Console.WriteLine("     EDITAR E-MAIL - 3");
                        Console.WriteLine("       EDITAR DATA - 4");
                        op = int.Parse(Console.ReadLine());
                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("Nome: ");
                                vetCli[i].Nome = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Telefone: ");
                                vetCli[i].Telefone = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("E-mail: ");
                                vetCli[i].Email = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Data de nascimento: ");
                                vetCli[i].DatNasc = Convert.ToDateTime(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Opção inválida!" +
                                    "\nCliente não atualizado!");
                                break;
                        }
                    } while (op != 0);
                    break;
                }
            } return cli;
        }
        static int Menu()
        {
            Console.WriteLine("\nSAIR -------- 0");
            Console.WriteLine("CADASTRAR --- 1");
            Console.WriteLine("LISTAR ------ 2");
            Console.WriteLine("EDITAR ------ 3");
            Console.WriteLine("REMOVER ----- 4");
            Console.WriteLine("PESQUISAR --- 5");
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            
            int qtd = 0, opcao;
            string telefone, nome;
            //Cliente[] vetCli = new Cliente[100];
            List<Cliente> listaCli = new List<Cliente>();
            do {
                opcao = Menu();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Tchau!");
                        break;
                    case 1:

                        listaCli.Add(Cadastrar(listaCli.Count + 1));               
                        
                        break;
                    case 2:
                        foreach(Cliente c in listaCli)
                        {
                            Console.WriteLine(c.ToString());
                        }
                        break;
                    case 3:
                        Class1.Consulta(cli);
                        break;
                    case 4:
                        Console.WriteLine("Pesquise pelo nome: ");
                        pesquisarNome = Console.ReadLine();
                        for (int i = 0; i < qtd; i++)
                        {
                            if (vetCli[i].Nome.Contains(pesquisarNome))
                            {
                                vetCli[i] = vetCli[qtd - 1];
                                qtd--;
                                Console.WriteLine("Excluido com sucesso");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Cliente não encontrado");
                            }
                        }
                        break;
                    case 5:
                        Class1.Consulta(vetCli, qtd);
                        /*string digitou = String.Empty;

                        Console.WriteLine("Digite algo para pesquisar...");
                        ConsoleKeyInfo simb = Console.ReadKey();
                        while (simb.Key != ConsoleKey.Enter)
                        {
                            digitou = digitou + simb.KeyChar;
                            Console.Clear();
                            Console.WriteLine("Resultados: ");

                            for (int i = 0; i < qtd; i++)
                            {
                                if (vetCli[i].Nome.ToUpper().Contains(digitou.ToUpper()))
                                {
                                    Console.WriteLine(vetCli[i].ToString());
                                    Console.WriteLine("---------------");
                                }
                            }
                            Console.WriteLine("\nNome procurado:" + digitou);
                            Console.WriteLine("Digite enter para encerrar...");
                            simb = Console.ReadKey();
                        }*/

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
