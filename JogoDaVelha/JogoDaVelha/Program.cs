using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JogoDaVelha
{
    internal class Program
    {
        public class Jogador
        {
            public string Nome { get; set; }
            public char Simbolo { get; set; }
        }
        static void FazerJogadaComputador(char[,] tabuleiro) 
        { 
                    Random random = new Random();
                    int linha, coluna;
                    do
                    {
                        linha = random.Next(0, 3);
                        coluna = random.Next(0, 3);
                    } while (tabuleiro[linha, coluna] != ' ');

                    tabuleiro[linha, coluna] = 'O';
        }

        static void Exercicio1Tabuleiro(char[,] tabuleiro) 
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


        static void Multplay()
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
                    Exercicio1Tabuleiro(casas);
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
                Exercicio1Tabuleiro(casas);
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

        static void SinglePlay()
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
                    Exercicio1Tabuleiro(casas);
                    Console.WriteLine(turno % 2 == 0 ? "\nTurno do jogador X" : "\nTurno do computador O");

                    if (turno % 2 == 0)
                    {
                        Console.WriteLine("\nTurno do jogador X");
                        Console.Write("\nDigite a linha: ");
                        line = int.Parse(Console.ReadLine());
                        Console.Write("Digite a coluna: ");
                        column = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("\nTurno do jogador O");
                        FazerJogadaComputador(casas);
                        line = 0;
                        column = 0;
                    }

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
                Exercicio1Tabuleiro(casas);
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

        static Jogador ObterDadosJogador()
        {
            Console.Write("Deseja informar seu nome e CPF (S/N)? ");
            var resposta = Console.ReadLine().ToLower();

            if (resposta == "s")
            {
                Console.Write("Digite seu nome: ");
                var nome = Console.ReadLine();
                Console.Write("Digite seu CPF: ");
                var cpf = Console.ReadLine();
                return new Jogador(nome, cpf);
            }

            return new Jogador();
        }

        public static List<string> Ranking(List<Jogador> players)
        {
            List<string> topPlayers = new List<string>();
            var sortedPlayers = players.OrderByDescending(p => p.numVitorias).Take(10);

            foreach (var player in sortedPlayers)
            {
                topPlayers.Add($"{player.Name}: {player.Wins} wins");
            }

            return topPlayers;
        }



        static void Main(string[] args)
        {

            int opcao = -1;
            List<Jogador> jogadores = new List<Jogador>();


            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("           Bem-vindo ao Jogo da Velha!\n\nEscolha a opção do exercício a ser executado");
                Console.WriteLine("   __________________________________");
                Console.Write(
                    "   01............................SinglePlay\n" +
                    "   02..............................Multplay\n" +
                    "   03.....................Cadastrar Jogador\n" +
                    "   04.....................Cadastrar Jogador\n" +
                    "   0...................................Sair\n");
                Console.WriteLine("   __________________________________\n");

                Console.Write("Digite a opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        SinglePlay();
                        break;
                    case 2:
                        Multplay();
                        break;
                    case 3:
                        Jogador jogador = ObterDadosJogador();
                        jogadores.Add(jogador);
                        break;
                    case 4:
                        List<string> ranking = Ranking(jogadores);
                        foreach (string item in ranking)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    default:
                        break;

                }
            }

        }
    }
}
