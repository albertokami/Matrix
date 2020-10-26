using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class AgentSmith : Pessoa
    {
        public AgentSmith() : base("AgentSmith")
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
            return "Olá Sr. Anderson.";
        }

    }
}
