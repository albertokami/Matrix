using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Matrix
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Matrix));
        List<Pessoa> pessoas;

        public Matrix()
        {
            log.Info("A Matrix foi criada!");
            pessoas = new List<Pessoa>();
        }

        public void acao()
        {
            try {
                AgentSmith agente1 = (AgentSmith)pessoas[0];
                log.Info(agente1.Atira());

                AgentSmith agente = (AgentSmith)pessoas[1];
                log.Info(agente.Corre());

                Neo neo = new Neo();
                log.Info(neo.Atira());
                log.Info(neo.Corre());
            }catch(Exception e)
            {
                log.Info("BUG NA MATRIX");
                log.Error(e);
            }
            
        }

        public void criarPersonagens()
        {
            AgentSmith pessoa = new AgentSmith();
            AgentSmith agentSmith = new AgentSmith();
            pessoas.Add(pessoa);
            pessoas.Add(agentSmith);
        }
    }
}
