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

            Console.Write($"{metro} metros em centimetro é igual a {centimetro}cm e em milimetro é igual a {milimetro}mm");
            Console.ReadKey();
        }

        static void Exercicio3()
        {
            Console.Write("Digite uma temperatura em Fahrenheit: ");
            float fahrenheit = float.Parse(Console.ReadLine());

            float celsiusA = (float)((fahrenheit - 32.0) * (5.0 / 9.0));
            int celsiusB = (int)((fahrenheit - 32) * ((float)5 / 9));

            Console.Write($"O valor {fahrenheit} em graus Celsius é {celsiusA}° C em ponto flutuante e {celsiusB}° C em inteiro.");
            Console.ReadKey();
        }

        static void Exercicio4()
        {
            Console.Write("Digite seu peso em Kg: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite seu altura em M: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.Write("O IMC é:" + imc);
            if (imc < 16.9F)
            {
                Console.Write("Muito abaixo do peso!");
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                Console.Write("Abaixo do peso!");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.Write("Peso normal!");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.Write("Acima do peso!");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.Write("Obesidade grau I!");
            }
            else if (imc >= 35 && imc <= 40)
            {
                Console.Write("Obesidade grau II!");
            }
            else
            {
                Console.Write("Obesidade grau III!");
            }

            Console.ReadKey();
        }

        static void Exercicio5()
        {
            Console.Write("Digite a primeira nota: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            float p1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            float p2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            float n3 = float.Parse(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            float p3 = float.Parse(Console.ReadLine());

            float mediaponderada = (n1 * p1 + n2 * p2 + n3 * p3) / (p1 + p2 + p3);

            Console.Write($"A média ponderada é {mediaponderada}");
            Console.ReadKey();
        }

        static void Exercicio6()
        {
            Console.Write("Digite o valor da massa(m): ");
            float massa = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor da velocidade(a): ");
            float velocidade = float.Parse(Console.ReadLine());

            float forca = (float)(massa * velocidade);

            Console.Write($"O valor da Força (F=m.a) é de {forca}.");
            Console.ReadKey();
        }

        static void Exercicio7()
        {
            Console.Write("Digite o salário atual do funcionário:");
            double salario = double.Parse(Console.ReadLine());

            double novoSalario = salario * 1.337;
            Console.Write($"Novo salário é {novoSalario}");
            Console.ReadKey();
        }

        static void Exercicio8()
        {
            Console.Write("Digite o valor em Reais (R$): ");
            float reais = float.Parse(Console.ReadLine());
            Console.Write("Digite a cotação do Dolar (U$): ");
            float cotacao = float.Parse(Console.ReadLine());

            float dolar = (float)(reais * cotacao);
            Console.Write($"O valor de R${reais} em Dolar é U${dolar}");
            Console.ReadKey();

        }

        static void Exercicio9()
        {
            Console.Write("Digite um valor inteiro: ");
            int num = int.Parse(Console.ReadLine());

            int antecessor = (num * num * num) - 1;
            int sucessor = (num * num) + 1;
            int soma = antecessor + sucessor;

            Console.Write($"O antecessor do seu triplo é {antecessor} e o sucessor do seu dobro é {sucessor}, sua soma é {soma}");
            Console.ReadKey();
        }

        static void Exercicio10()
        {
            Console.Write("Digite um número inteiro de 4 digitos: ");
            int numero = int.Parse(Console.ReadLine());

            int milhar = numero / 1000;
            int centena = (numero % 1000) / 100;
            int dezena = (numero % 100) / 10;
            int unidade = numero % 10;

            Console.WriteLine(milhar);
            Console.WriteLine(centena);
            Console.WriteLine(dezena);
            Console.WriteLine(unidade);
            Console.ReadKey();
        }

        static void Exercicio11()
        {
            double valorInvestimento = 1000.0;

            valorInvestimento = valorInvestimento * (1 - 0.124);  // queda de 12,4%
            valorInvestimento = valorInvestimento * (1 + 0.018);  // subida de 1,8%
            valorInvestimento = valorInvestimento * (1 + 0.056);  // subida de 5,6%
            valorInvestimento = valorInvestimento * (1 - 0.045);  // queda de 4,5%

            Console.WriteLine($"O valor atual do investimento de Marquesito é R${valorInvestimento}");
        }

        static void Exercicio12()
        {

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
                    "12.......Exercício12\n" +
                    "0.......Sair\n\n");

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
                    case 7:
                        Exercicio7();
                        break;
                    case 8:
                        Exercicio8();
                        break;
                    case 9:
                        Exercicio9();
                        break;
                    case 10:
                        Exercicio10();
                        break;
                    case 11:
                        Exercicio11();
                        break;
                    case 12:
                        Exercicio12();
                        break;
                    default:
                        break;

                }
            }

        }
    }
}
