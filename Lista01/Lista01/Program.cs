using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    internal class Program
    {
        static void Exercicio1()
        {
            Console.Write("Digite o valor do salário mínimo atual:");
            float salarioMinimo = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor do salário de uma pessoa:");
            float salarioPessoa = float.Parse(Console.ReadLine());

            float descontoINSS = (float)(salarioPessoa * 0.085);
            float salarioLiquido = salarioPessoa - descontoINSS;
            float salarioMinimoLiquido = salarioLiquido / salarioMinimo;
            Console.Write($"O salarío da pessoa é igual a {salarioMinimoLiquido} salarios mínimos");
            Console.ReadKey();
            
        }

        static void Exercicio2()
        {
            Console.Write("Digite um valor em metros: ");
            float metro = float.Parse(Console.ReadLine());

            float centimetro = (float)(metro * 100);
            float milimetro = (float)(metro * 1000);

            Console.Write($"{metro} metros em centimetro é igual a {centimetro} e em milimetro é igual a {milimetro}");
            Console.ReadKey();
        }

        static void Exercicio3()
        {
            Console.Write("Digite uma temperatura em Fahrenheit: ");
            float fahrenheit = float.Parse(Console.ReadLine());

            float celsiusA = (float)((fahrenheit - 32.0) * (5.0/9.0));
            int celsiusB = (int)((fahrenheit - 32) * ((float)5 / 9));

            Console.Write($"O valor {fahrenheit} em graus Celsius é {celsiusA}° em ponto flutuante e {celsiusB}° em inteiro.");
            Console.ReadKey();
        }

        static void Exercicio4()
        {
            Console.Write("Digite seu peso: ");
            float peso = float.Parse(Console.ReadLine());
            Console.Write("Digite seu altura: ");
            float altura = float.Parse(Console.ReadLine());

            float imc = (float)((peso / (altura * altura)));
            Console.Write($"O IMC é {imc}");
            if()
        }

        static void Main(string[] args)
        {

            int opcao = -1;
            

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("Escolha a opção do exercício a ser executado");
                Console.Write("01.......Exercício01\n" +
                    "02.......Exercício02\n" +
                    "03.......Exercício03\n" +
                    "04.......Exercício04\n" +
                    "05.......Exercício05\n" +
                    "06.......Exercício06\n" +
                    "07.......Exercício07\n" +
                    "08.......Exercício08\n" +
                    "09.......Exercício09\n" +
                    "10.......Exercício10\n" +
                    "11.......Exercício11\n" +
                    "12.......Exercício12\n\n");

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
