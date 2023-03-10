using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
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
                    
                    default:
                        break;

                }
            }

        }
    }
}
