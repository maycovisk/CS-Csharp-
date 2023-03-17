using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaIFSP
{
    internal class Cliente
    {
        private int id;
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
            string saida =  "\nNOME: " + Nome +
                            "\nTELEFONE:" + Telefone +
            if(!String.IsNullOrEmpty(Email))
                saida = saida + "\nEMAIL:" + Email;
            if(!(DatNasc.CompareTo(Convert.ToDateTime("01/01/0001")) == 0))
            //if(DatNasc.ToShortDateString() == Convert.ToDateTime("01/01/0001").ToString())
                saida += "\nNASCIMENTO: " + DatNasc.ToShortDateString();
            return saida;
                
               
                
        }
    }
}
