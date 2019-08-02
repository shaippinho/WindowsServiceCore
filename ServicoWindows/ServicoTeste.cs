using System;
using System.IO;

namespace ServicoWindows
{
    //Classe de Exemplo, Serviço de Teste
    public class ServicoTeste : System.ServiceProcess.ServiceBase
    {

        //Construtor
        public ServicoTeste()
        {
            ServiceName = "ServicoTeste";
        }


        protected override void OnStart(string[] args)
        {
            string filename = CheckFileExists();
            
            File.AppendAllText(filename, $"{DateTime.Now} started.{Environment.NewLine}");
        }

        protected override void OnStop()
        {
            string filename = CheckFileExists();

            File.AppendAllText(filename, $"{DateTime.Now} stopped.{Environment.NewLine}");
        }

        private static string CheckFileExists()
        {
            string filename = @"C:\Work\Testes\ServicoTeste\MyService.txt";

            if (!File.Exists(filename))
            {
                File.Create(filename);
            }

            return filename;
        }

    }
}