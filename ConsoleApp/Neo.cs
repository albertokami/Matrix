using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Neo : Pessoa
    {
        public Neo() : base("Neo")
        {
        }
        public string Atira()
        {
            return "Neo atira";
        }

        public string Luta()
        {
            return "Neo luta";
        }
        public override string Fala()
        {
            return "Eu sou o escolhido";
        }
    }
}
