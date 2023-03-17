using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaIFSP
{
    internal class Cliente
    {
        private string nome;
        private string telefone;
        private string email;
        private DateTime datNasc;

        public Cliente(string nome, string tel)
        {
            Nome = nome;
            Telefone = tel; 
        }
        public Cliente(string nome, string tel, string email, DateTime datNasc)
        {
            Nome = nome;
            Telefone = tel;
            Email = email;
            DatNasc = datNasc;
        }

        public String telefone
        {
            get { return Telefone; }
            set { telefone = value; }
        }

        public override string ToString()
        {
            return
                "\nNOME: " + Nome +
                "\nTELEFONE:" + Telefone +
                "\nEMAIL:" + Email +
                "\nNASCIMENTO: " + DatNasc.ToShortDateString();
        }
    }
}
