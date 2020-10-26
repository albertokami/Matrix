using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp.Logger
{
    class LoggerConfig
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LoggerConfig));

        /*
         * Para mais detalhes veja este link
         * https://logging.apache.org/log4net/release/manual/configuration.html
         */
        public static void load()
        {
            try
            {
                using (StreamReader sr = new StreamReader("Logger//config.xml")) //le o arquivo de configuracao
                {
                    XmlConfigurator.Configure(sr.BaseStream);// carrega para a classe XmlConfigurator do log4net
                    log.Info("Log inicializado com sucesso!");// Se tudo der certo isto vai aparecer no matrix.log
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("DEU RUIM");
                Console.WriteLine(e);
            }
            
        }
        
    }
}
