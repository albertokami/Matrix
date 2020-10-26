using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public virtual string Anda()
        {
            return Nome + " anda.";
        }

        public virtual string Corre()
        {
            return Nome + " corre.";
        }

        public virtual string Fala()
        {
            return Nome + " fala.";
        }

    }
}
