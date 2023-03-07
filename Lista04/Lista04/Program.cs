using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lista04
{
    internal class Program
    {
        static void Legth(string texto)
        {
            Console.WriteLine("**A propriedade Length retorna o número de caracteres em uma string.**");
            
            int length = texto.Length;
            
            Console.WriteLine("O comprimento da string " + texto +" é: " + length);
            Console.ReadKey();
        }

        static void ToCharArray(string texto)
        {
            Console.WriteLine("**O método ToCharArray retorna uma matriz de caracteres que representa a string.**");
            
            char[] chars = texto.ToCharArray();
            
            Console.WriteLine("A string em forma de array de caracteres: ");
            
            foreach (char c in chars)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }

        static void Trim(string texto)
        {
            Console.WriteLine("**O método Trim remove os espaços em branco do início e do fim de uma string.**");
            
            string trimmedString = texto.Trim();
            
            Console.WriteLine(trimmedString);
            Console.ReadKey();
        }

        static void SubString(string texto)
        {
            int length = texto.Length;
            
            Console.WriteLine("**O método Substring retorna uma parte da string especificada.**");
            Console.WriteLine("As 28 últimas letras do texto são: ");
            
            string substring = texto.Substring(length - 28);
            
            Console.WriteLine(substring);
            Console.WriteLine("Não quero forçar nada, é só um exemplo.");
            Console.ReadKey();
        }

        static void Split()
        {
            Console.WriteLine("**O método Split divide uma string em substrings com base em um separador especificado e retorna uma matriz das substrings resultantes.**");
            
            string exemploString = "Marques,Paulo,Helton,João,Avelino,Jorge";
            Console.WriteLine(exemploString);
            
            string[] fruits = exemploString.Split(',');
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadKey();
        }

        static void Contains(string texto)
        {
            Console.WriteLine("**O método Contains retorna um valor booleano que indica se uma string especificada ocorre dentro de outra string.**");
            
            bool contem = texto.Contains("mereço até um ponto a mais!");
            
            Console.WriteLine("A string contém 'mereço até um ponto a mais!'? " + contem);
            Console.ReadKey();
        }

        static void EndsWith(string texto)
        {
            Console.WriteLine("**O método EndsWith é usado para verificar se uma string termina com uma substring específica.**");
            
            bool terminaCom = texto.EndsWith("! ");
            
            Console.WriteLine("A string termina com '! '? " + terminaCom);
            Console.ReadKey();  
        }

        static void Equals(string texto)
        {
            Console.WriteLine("**O método Equals é usado para verificar se duas strings são iguais.**");
            
            string texto1 = "Essa lista foi mais difícil do que pensei!";
            
            Console.WriteLine("A primeira string é: " + texto);
            Console.WriteLine("A segunda string é: " + texto1);
            
            bool saoIguais = texto.Equals(texto1);
            
            Console.WriteLine("As strings são iguais? " + saoIguais);
            Console.ReadKey();
        }

        static void GetType(string texto)
        {
            Console.WriteLine("**O método GetType é usado para obter o tipo de objeto de uma string.**");
            
            Type tipo = texto.GetType();
            
            Console.WriteLine("O tipo do objeto é: " + tipo);
            Console.ReadKey();
        }

        static void IndexOf(string texto)
        {
            Console.WriteLine("**O método IndexOf é usado para encontrar a posição de uma substring dentro de uma string.**");
            
            int posicao = texto.IndexOf("ponto");
            
            Console.WriteLine("A posição de 'ponto' é: " + posicao);
            Console.ReadKey();
        }

        static void Empty()
        {
            Console.WriteLine("**A propriedade Empty é usada para obter uma string vazia.**");
            
            string textoVazio = string.Empty;
            
            Console.WriteLine("A string vazia é: " + textoVazio);
            Console.ReadKey();
        }

        static void Insert(string texto)
        {
            Console.WriteLine("**O método Insert é usado para inserir uma substring em uma posição específica de uma string.**");
            
            string novoTexto = texto.Insert(29, " as provas não,");
            
            Console.WriteLine("O novo texto é: " + novoTexto);
            Console.ReadKey();
        }

        static void LastIndexOf(string texto)
        {
            Console.WriteLine("**O método LastIndexOf é usado para encontrar a última posição de uma substring dentro de uma string.**");
            Console.Write("A string para este exemplo é: " + texto + " A ultima letra \"o\" está na posição: ");
            
            int lastIndex = texto.LastIndexOf("o");
            
            Console.WriteLine(lastIndex);
            Console.ReadKey();
        }

        static void Remove(string texto)
        {
            Console.WriteLine("**O método Remove remove um número especificado de caracteres de uma posição específica em uma string.**");
            Console.WriteLine("A string para este exemplo é: " + texto + ", da posição 28 remove as 28 posições seguintes");
            
            string newString = texto.Remove(28, 28);
            
            Console.WriteLine(newString);
            Console.ReadKey();
        }

        static void Replace(string texto)
        {
            Console.WriteLine("**O método Replace substitui todas as ocorrências de um caractere ou substring em uma string por outra string especificada.**");
            Console.Write("Se trocarmos o \"aulas\" por \"listas\" no texto, ficará: ");
            
            string newTexto = texto.Replace("aulas", "listas");
            
            Console.WriteLine(newTexto);
            Console.ReadKey();
        }

        static void StartsWith(string texto)
        {
            Console.WriteLine("\n\n**A propriedade StartsWith retorna um valor Booleano que indica se a string começa com a substring especificada.**");
            Console.WriteLine("A string \"" + texto + "\" começa com : As aulas");
            
            bool startsWithHello = texto.StartsWith(" As aulas");
            
            Console.WriteLine(startsWithHello);
            Console.ReadKey();
        }

        static void ToLower(string texto)
        {
            Console.WriteLine("\n\n**O método ToLower retorna uma cópia da string com todos os caracteres convertidos em minúsculas.**");
            
            string lowerCaseString = texto.ToLower();
            
            Console.WriteLine(lowerCaseString);
            Console.ReadKey();
        }

        static void ToUpper(string texto)
        {
            Console.WriteLine("\n\n**O método ToUpper retorna uma cópia da string com todos os caracteres convertidos em maiúsculas.**");
            
            string upperCaseString = texto.ToUpper();
            
            Console.WriteLine(upperCaseString);
            Console.ReadKey();
        }

        static void metodoToString()
        {
            Console.WriteLine("**A classe string tem um método ToString() que pode ser usado para formatar datas, horas e números de diversas maneiras. Isso é feito usando especificadores de formato que são colocados dentro de chaves {}.**");
            Console.WriteLine("Segue exemplos:");
            
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("dd/MM/yyyy");
            
            Console.WriteLine(formattedDate);
            
            string formattedTime = now.ToString("HH:mm:ss");
            
            Console.WriteLine(formattedTime);
            
            double myNumber = 1234567.89;
            string formattedNumber = myNumber.ToString("N2");
            
            Console.WriteLine(formattedNumber);
            Console.ReadKey();
        }

        static void metodoIsNullOrEmpty(string texto)
        {
            Console.WriteLine("\n\n**O método IsNullOrEmpty retorna um valor Booleano que indica se a string é nula ou vazia.**");
            
            bool isNullOrEmpty = string.IsNullOrEmpty(texto);
            
            Console.WriteLine(isNullOrEmpty);
            Console.ReadKey();
        }

        static void metodoCopy(string texto)
        {
            Console.WriteLine("**O método Copy cria uma nova instância de uma cadeia de caracteres com o mesmo conteúdo da cadeia de caracteres original.**");
            
            string copiedString = string.Copy(texto);
            
            Console.WriteLine(texto);
            Console.WriteLine(copiedString);
            Console.ReadKey();
        }



        static void Main(string[] args)
        {

            int opcao = -1;
            string texto = " As aulas do Marques são TOP, mereço até um ponto a mais! ";


            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("           Bem-vindo a Lista04!\n\nEscolha a opção da propriedade ou método a ser executado");
                
                Console.WriteLine("Explicação e exemplos das seguintes propriedades e métodos relacionados a STRINGs\n\n");
                Console.WriteLine("Os exemplos serão com o texto \"" + texto+"\"");
                Console.WriteLine("\n   __________________________________");
                Console.Write("   01...........................Legth\n" +
                    "   02.....................ToCharArray\n" +
                    "   03............................Trim\n" +
                    "   04.......................SubString\n" +
                    "   05...........................Split\n" +
                    "   06........................Contains\n" +
                    "   07........................EndsWith\n" +
                    "   08..........................Equals\n" +
                    "   09.........................GetType\n" +
                    "   10.........................IndexOf\n" +
                    "   11...........................Empty\n" +
                    "   12..........................Insert\n" +
                    "   13.....................LastIndexOf\n" +
                    "   14..........................Remove\n" +
                    "   15.........................Replace\n" +
                    "   16......................StartsWith\n" +
                    "   17.........................ToLower\n" +
                    "   18.........................ToUpper\n" +
                    "   19..................metodoToString\n" +
                    "   20.............metodoIsNullOrEmpty\n" +
                    "   21......................metodoCopy\n" +
                    "   0.............................Sair\n");
                Console.WriteLine("   __________________________________\n");

                Console.Write("Digite a opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Legth(texto); break;
                    case 2:
                        ToCharArray(texto); break;
                    case 3:
                        Trim(texto); break;
                    case 4:
                        SubString(texto); break;
                    case 5:
                        Split(); break;
                    case 6:
                        Contains(texto); break;
                    case 7:
                        EndsWith(texto); break;
                    case 8:
                        Equals(texto); break;
                    case 9:
                        GetType(texto); break;
                    case 10:
                        IndexOf(texto); break;
                    case 11:
                        Empty(); break;
                    case 12:
                        Insert(texto); break;
                    case 13:
                        LastIndexOf(texto); break; 
                    case 14:
                        Remove(texto); break;
                    case 15:
                        Replace(texto); break;
                    case 16:
                        StartsWith(texto); break;
                    case 17:
                        ToLower(texto); break;
                    case 18:
                        ToUpper(texto); break;
                    case 19:
                        metodoToString(); break;
                    case 20:
                        metodoIsNullOrEmpty(texto); break;
                    case 21:
                        metodoCopy(texto); break;
                    default: break;

                }
            }

        }
    }
}
