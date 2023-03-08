using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    internal class Program
    {
        static void Exercicio1()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            float[] vetor = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}º numero do vetor: ");
                vetor[i] = float.Parse(Console.ReadLine());
            }

            float menor = vetor[0];
            float maior = vetor[0];
            float soma = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
                soma += vetor[i];
                    
            }

            float media = 0;
            media = soma / n;

            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Média dos números é: " + media);
            Console.ReadKey();
        }

        static void Exercicio2()
        {
            int n;
            int soma = 0;
            float media;
            do
            {
                Console.Write("Digite o tamanho do vetor QUE SEJA MAIOR QUE ZERO!: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            int[] vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}º numero do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
                soma += vetor[i];
            }

            media = (float)soma / n;
            Console.WriteLine("Média dos números é: " + media);
            Console.WriteLine("Os números maiores ou iguais a média de todos os numeros são: ");

            for (int i = 0; i < n; i++)
            {
                if(vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }

            
            Console.ReadKey();
        }

        static void Exercicio3()
        {
            int n;
            int soma = 0;
            float media;
            Random randNum = new Random();
            do
            {
                Console.Write("Digite o tamanho do vetor QUE SEJA MAIOR QUE ZERO!: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            int[] vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                vetor[i] = randNum.Next(1,999);
                Console.WriteLine($"O {i+1}º número aleatório é: {vetor[i]}");
                soma += vetor[i];
            }

            media = (float)soma / n;
            Console.WriteLine("Média dos números é: " + media);
            Console.WriteLine("Os números maiores ou iguais a média de todos os numeros são: ");

            for (int i = 0; i < n; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }


            Console.ReadKey();
        }

        static void Exercicio4Tabuleiro(char[,] tabuleiro) 
        { 
            Console.Clear();
            Console.WriteLine(
                    $"         col 1|col 2|col 3 \n" +
                    $"Linha 1    {tabuleiro[0,0]}  |  {tabuleiro[0,1]}  |  {tabuleiro[0,2]}  " +
                    "\n         -----------------\n" +
                    $"Linha 2    {tabuleiro[1,0]}  |  {tabuleiro[1,1]}  |  {tabuleiro[1,2]}  " +
                    "\n         -----------------\n" +
                    $"Linha 3    {tabuleiro[2,0]}  |  {tabuleiro[2,1]}  |  {tabuleiro[2,2]  }"
                );
        }

        static void Exercicio4()
        {
            char[,] casas = new char[3,3];
            char continuarJogando;
            int contadorJogadas, line, column, turno = 0, i, j;

            do
            {
                contadorJogadas = 1;
                for (i = 0; i <= 2; i++)
                {
                    for (j = 0; j <= 2; j++)
                    {
                        casas[i,j] = ' ';
                    }
                }
                do
                {
                    Exercicio4Tabuleiro(casas);
                    Console.WriteLine(turno % 2 == 0 ? "\nTurno do jogador X" : "\nTurno do jogador O");

                    Console.Write("\nDigite a linha: ");
                    line = int.Parse(Console.ReadLine());
                    Console.Write("Digite a coluna: ");
                    column = int.Parse(Console.ReadLine());

                    if (line < 1 || column < 1 || line > 3 || column > 3)
                    {
                        line = 0;
                        column = 0;
                    }
                    else if (casas[line - 1, column - 1] != ' ')
                    {
                        line = 0;
                        column = 0;
                    }
                    else
                    {
                        if (turno % 2 == 0)
                            casas[line - 1, column - 1] = 'X';
                        else
                            casas[line - 1, column - 1] = 'O';
                        turno++;
                        contadorJogadas++;
                    }
                    if (casas[0,0] == 'X' && casas[0,1] == 'X' && casas[0,2] == 'X') { contadorJogadas = 11; }
                    if (casas[1,0] == 'X' && casas[1,1] == 'X' && casas[1,2] == 'X') { contadorJogadas = 11; }
                    if (casas[2,0] == 'X' && casas[2,1] == 'X' && casas[2,2] == 'X') { contadorJogadas = 11; }
                    if (casas[0,0] == 'X' && casas[1,0] == 'X' && casas[2,0] == 'X') { contadorJogadas = 11; }
                    if (casas[0,1] == 'X' && casas[1,1] == 'X' && casas[2,1] == 'X') { contadorJogadas = 11; }
                    if (casas[0,2] == 'X' && casas[1,2] == 'X' && casas[2,2] == 'X') { contadorJogadas = 11; }
                    if (casas[0,0] == 'X' && casas[1,1] == 'X' && casas[2,2] == 'X') { contadorJogadas = 11; }
                    if (casas[0,2] == 'X' && casas[1,1] == 'X' && casas[2,0] == 'X') { contadorJogadas = 11; }

                    if (casas[0,0] == 'O' && casas[0,1] == 'O' && casas[0,2] == 'O') { contadorJogadas = 12; }
                    if (casas[1,0] == 'O' && casas[1,1] == 'O' && casas[1,2] == 'O') { contadorJogadas = 12; }
                    if (casas[2,0] == 'O' && casas[2,1] == 'O' && casas[2,2] == 'O') { contadorJogadas = 12; }
                    if (casas[0,0] == 'O' && casas[1,0] == 'O' && casas[2,0] == 'O') { contadorJogadas = 12; }
                    if (casas[0,1] == 'O' && casas[1,1] == 'O' && casas[2,1] == 'O') { contadorJogadas = 12; }
                    if (casas[0,2] == 'O' && casas[1,2] == 'O' && casas[2,2] == 'O') { contadorJogadas = 12; }
                    if (casas[0,0] == 'O' && casas[1,1] == 'O' && casas[2,2] == 'O') { contadorJogadas = 12; }
                    if (casas[0,2] == 'O' && casas[1,1] == 'O' && casas[2,0] == 'O') { contadorJogadas = 12; }
                } while (contadorJogadas <= 9);
                Exercicio4Tabuleiro(casas);
                if (contadorJogadas == 10)
                    Console.WriteLine("Jogo Empatado");
                if (contadorJogadas == 11)
                    Console.WriteLine("Jogador X WINS!");
                if (contadorJogadas == 12)
                    Console.WriteLine("Jogador O WINS!");
                Console.Write("Deseja jogar novamente? [S / N]");
                continuarJogando = char.Parse(Console.ReadLine());
            } while (continuarJogando == 's' || continuarJogando == 'S');
        }



        static void Main(string[] args)
        {

            int opcao = -1;


            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("           Bem-vindo a Lista03!\n\nEscolha a opção do exercício a ser executado");
                Console.WriteLine("   __________________________________");
                Console.Write("   01.....................Exercício01\n" +
                    "   02.....................Exercício02\n" +
                    "   03.....................Exercício03\n" +
                    "   04.....................Exercício04\n" +
                    "   0.............................Sair\n");
                Console.WriteLine("   __________________________________\n");

                Console.Write("Digite a opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    default:
                        break;

                }
            }

        }
    }
}
