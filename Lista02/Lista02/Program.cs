using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    internal class Program
    {
        static void Exercicio1()
        {
            int[] num = new int[172];
            Random randNum = new Random();

            for (int i = 0; i < 172; i++)
            {
                num[i] = randNum.Next(23,9568); 
            }

            int menor = num[0];
            int maior = num[0];
            int soma = 0;
            int qtdParesMenoresQue100 = 0;

            for (int i = 0; i < 172; i++)
            {
                if (num[i] < menor)
                {
                    menor = num[i];
                }
                if (num[i] > maior)
                {
                    maior = num[i];
                }
                if (num[i] % 2 == 0 && num[i] < 100)
                {
                    soma += num[i];
                    qtdParesMenoresQue100++;
                }
            }

            int media = 0;
            if (qtdParesMenoresQue100 > 0)
            {
                media = soma / qtdParesMenoresQue100;
            }

            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Média dos valores pares menores que 100: " + media);
            Console.ReadKey();
        }

        static void Exercicio2()
        {
            int num;
            int contador = 0;
            int soma = 0;
            double media = 0;

            do
            {
                Console.Write("Numero {0}: ", contador + 1);
                num = int.Parse(Console.ReadLine());

                if(num >= 0)
                {
                    soma += num;
                    contador++;
                }
            }while(num >= 0);

            if(contador >0)
            {
                media = (double)soma/ contador;
            }

            Console.WriteLine("A média é: {0}", media);
            Console.ReadKey();
        }

        static void Exercicio3()
        {
            Console.Write("Digite o valor de X como valor inicial: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y como valor final: ");
            int y = int.Parse(Console.ReadLine());

            for(int i = x; i <= y; i++)
            {
                if (i % 7 == 3 || i % 7 == 5)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        static void Exercicio4()
        {
            Console.Write("Digite um número P positivo: ");
            int p = int.Parse(Console.ReadLine());

            
            Console.ReadKey();
        }

        static void Exercicio5()
        {
            Console.Write("Digite um número de linhas: ");
            int numLinhas = int.Parse(Console.ReadLine());   

            for(int i = 1; i <= numLinhas; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Exercicio6()
        {
            Console.Write("Digite um número de linhas: ");
            int numLinhas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numLinhas; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            int opcao = -1;


            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("           Bem-vindo a Lista01!\n\nEscolha a opção do exercício a ser executado");
                Console.WriteLine("   __________________________________");
                Console.Write("   01.....................Exercício01\n" +
                    "   02.....................Exercício02\n" +
                    "   03.....................Exercício03\n" +
                    "   04.....................Exercício04\n" +
                    "   05.....................Exercício05\n" +
                    "   06.....................Exercício06\n" +
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
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Exercicio6();
                        break;
                    default:
                        break;

                }
            }

        }
    }
}