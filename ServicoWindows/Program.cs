using System;

namespace ServicoWindows
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var service = new ServicoTeste())
            {
                System.ServiceProcess.ServiceBase.Run(service);
            }

        }
        
    }
}
