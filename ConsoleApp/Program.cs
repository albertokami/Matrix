using ConsoleApp.Logger;
using log4net;
using System;

namespace ConsoleApp
{
    /* Isto eh apenas exemplo de como configurar o log4net */
    class Program
    {
        /*ILog e LogManager são classes da log4net para preparar este classe para logar os dados*/
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            LoggerConfig.load();
            log.Info("Inicio");

            Matrix matrix = new Matrix();
            matrix.criarPersonagens();
            matrix.acao();

            log.Info("Fim");
        }
    }
}
