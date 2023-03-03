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
                    default:
                        break;

                }
            }

        }
    }
}
