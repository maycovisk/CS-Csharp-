using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaIFSP
{
    public abstract class Class1
    {
        public static void Consulta(List<Cliente> vetCli)
        {
            string digitou = String.Empty;

            Console.WriteLine("Digite algo para pesquisar...");
            ConsoleKeyInfo simb = Console.ReadKey();
            while (simb.Key != ConsoleKey.Enter)
            {
                digitou = digitou + simb.KeyChar;
                Console.Clear();
                Console.WriteLine("Resultados: ");

                for (int i = 0; i < vetCli.Count; i++)
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
            }
        }
    }
}
