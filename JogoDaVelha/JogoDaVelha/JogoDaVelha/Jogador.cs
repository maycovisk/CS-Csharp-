using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogador
{
    class Jogador
    {
        private string nome;
        private string cpf;
        private int numVitorias;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public int NumVitorias
        {
            get { return numVitorias; }
            set { numVitorias = value; }
        }

        public Jogador(int numVitorias)
        {
            NumVitorias = numVitorias;
        }

        public Jogador(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
    }
}
