using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lista05
{
    internal class Program
    {
        
        static void Exercicio1()
        {
            DateTime now = DateTime.Now;
            
            string day = now.ToString("D"); //data completa
            string hours = now.ToString("HH"); //hora
            string nameMachine = Environment.MachineName; //nome da maquina

            if (int.Parse(hours) >= 6 && int.Parse(hours) < 12) {
                Console.WriteLine($"Bom dia MARQU\nVocê está utilizando a máquina {nameMachine}\nHoje é {day}");
            }
            else if (int.Parse(hours) >=12 && int.Parse(hours) < 18)
            {
                Console.WriteLine($"Boa tarde MARQU\nVocê está utilizando a máquina {nameMachine}\nHoje é {day}");
            }
            else
            {
                Console.WriteLine($"Boa noite MARQU\nVocê está utilizando a máquina {nameMachine}\nHoje é {day}");
            }

            Console.ReadKey();
        }

        static void Exercicio2()
        {
            string stringDoCao = "3.2649195;9300419;8240871%2791073;3917173;9851056#9925124,4763040.0965918;93 09297%1010589;5634190,7310819#0258142,0929306.0592849#2628868;1392209;49417 11%6802169%3655235.1180040#6889981;4529558,3395538;3095206.8162707,5306168 %3277453.0758859,8014857.6402319%2329297.7429486#4680437%5500518#7865391 #2873377#8086382#5447877%5426116,5085634%7224325#5798439,1178516%431207 2.0796522.9304179;0434651%6509028#4787438#8491024%3015385,5290222%529492 7%5561596.0460024%1321386,1368206;3408249,6508625.7336954%8002371;7576263 %3747889#7408701%0201462#4900590;9622169#0048623%4969522%4528884#49907 86.3003232;6365305%3586311.5647329%3264194;2114295,3171009;9876958,4020305, 1632979%0031475.2552181%2602640.5303671.8059160%4988532.4693670%9150725,3 340225,6376627.0780785;0990199.4341820.0463039%3299347,7393254%4523854#660 3120%9368998#5944279,9085068#8137433,3239866,6379195#7431356.5898614.58104 97.3487996#5400022#6149677,8533754%6088682%2032031.6332587,7284531#923933 1%8866454,3964222#3314980#8428029.2546101;7316677%0460178;8789264;9316756. 1965642;7585590,7383219;9062609,8482023,5717895;2684729;0466794%5370084,0484 922;4599156,5815576%3414149.1343440#16129";

            string limparString = stringDoCao.Replace(",", "").Replace(".", "").Replace(";", "").Replace("%", "").Replace("#", "").Replace(" ", "");
            //limparString = new string(limparString.Where(char.IsDigit).ToArray());   //VI NO GOOGLE E NÃO ENTENDI O CÓDIGO

            int maiorProduto = 0;
            string maxNumerosProdutos = "";
            int strLenght = 5;

            for(int i = 0; i < limparString.Length - strLenght; i++)
            {
                string sequencia = limparString.Substring(i , strLenght);
                int produto = 1;

                foreach(char c in sequencia)
                {
                    int numero = int.Parse(c.ToString());
                    produto *= numero;
                }

                if(produto > maiorProduto)
                {
                    maiorProduto = produto;
                    maxNumerosProdutos = sequencia;
                }
            }

            Console.WriteLine($"Os 5 números consecutivos que retornam o maior produto são: {maxNumerosProdutos}");
            Console.WriteLine($"O maior produto é: {maiorProduto}");

            Console.ReadKey();
        }

        static void Exercicio3()
        {
            string stringDoCao = "3.2649195;9300419;8240871%2791073;3917173;9851056#9925124,4763040.0965918;93 09297%1010589;5634190,7310819#0258142,0929306.0592849#2628868;1392209;49417 11%6802169%3655235.1180040#6889981;4529558,3395538;3095206.8162707,5306168 %3277453.0758859,8014857.6402319%2329297.7429486#4680437%5500518#7865391 #2873377#8086382#5447877%5426116,5085634%7224325#5798439,1178516%431207 2.0796522.9304179;0434651%6509028#4787438#8491024%3015385,5290222%529492 7%5561596.0460024%1321386,1368206;3408249,6508625.7336954%8002371;7576263 %3747889#7408701%0201462#4900590;9622169#0048623%4969522%4528884#49907 86.3003232;6365305%3586311.5647329%3264194;2114295,3171009;9876958,4020305, 1632979%0031475.2552181%2602640.5303671.8059160%4988532.4693670%9150725,3 340225,6376627.0780785;0990199.4341820.0463039%3299347,7393254%4523854#660 3120%9368998#5944279,9085068#8137433,3239866,6379195#7431356.5898614.58104 97.3487996#5400022#6149677,8533754%6088682%2032031.6332587,7284531#923933 1%8866454,3964222#3314980#8428029.2546101;7316677%0460178;8789264;9316756. 1965642;7585590,7383219;9062609,8482023,5717895;2684729;0466794%5370084,0484 922;4599156,5815576%3414149.1343440#16129";

            string limparString = stringDoCao.Replace(",", "").Replace(".", "").Replace(";", "").Replace("%", "").Replace("#", "").Replace(" ", "");
            string[] substrings = limparString.Split(new string[] { "11" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string substring in substrings)
            {
                if (substring.Length > 0)
                {
                    int soma = substring.Where(c => char.IsDigit(c)).Sum(c => c - '0');
                    Console.WriteLine(substring + "11 " + soma);
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
                Console.WriteLine("           Bem-vindo a Lista05!\n\nEscolha a opção do exercício a ser executado");
                Console.WriteLine("   __________________________________");
                Console.Write("   01.....................Exercício01\n" +
                    "   02.....................Exercício02\n" +
                    "   03.....................Exercício03\n" +
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
