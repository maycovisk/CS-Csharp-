using System;

namespace JogoDaVelha
{
    class JogoDaVelha
    {
        private bool fimDeJogo;
        private char[] posicao;
        private char turno;

        public JogoDaVelha()
        {
            fimDeJogo= false;
            posicao = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            turno = 'X'

        }

        public void Iniciar()
        {
            while(!fimDeJogo)
            {
                Tabuleiro();
                LerEscolhaDoUsuario();
                Tabuleiro();
                VerificarFimDeJogo();
                AlterarTurno();
            }
        }

        private void AlterarTurno()
        {
            turno = turno == 'X' ? 'O' : 'X';
        }

        private void VerificarFimDeJogo()
        {

        }

        private void LerEscolhaDoUsuario()
        {
            bool validador = int.TryParse(Console.ReadLine(), out int posicaoEscolhida);

            while(!validador)
            {
                Console.WriteLine("ERROR: O campo escolhido é invalido!\nPor favor, digite um número de 1 a 9 que esteja livre na tabela!");
                validador = int.TryParse(Console.ReadLine(), out posicaoEscolhida);
            }
        }

        private void Tabuleiro()
        {
            Console.Clear();
            Console.WriteLine(RenderizarTabuleiro());
        }

        private string RenderizarTabuleiro()
        {
            return  $"__{posicao[0]__|__{posicao[1]__|__{posicao[2]__" +
                    $"__{posicao[3]__|__{posicao[4]__|__{posicao[5]__" +
                    $"  {posicao[6]  |  {posicao[7]  |  {posicao[8]  " ;
        }


    }
}



