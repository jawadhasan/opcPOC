using Opc.Ua;
using Opc.Ua.Configuration;
using System;

namespace OPCUAServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationInstance app = new ApplicationInstance();
            app.ApplicationType = ApplicationType.Server;
            app.ConfigSectionName = "OPCUAServer";

            try
            {
                if (app.ProcessCommandLine())
                {
                    return;
                }

                if (!Environment.UserInteractive)
                {
                    app.StartAsService(new Server());
                    return;
                }

                app.LoadApplicationConfiguration(@"Data\OPCUAServer.Config.xml", false).Wait();
                app.CheckApplicationInstanceCertificate(false, 0).Wait();

                app.Start(new Server()).Wait();


                foreach (EndpointDescription endpoint in app.Server.GetEndpoints())
                {
                    Console.WriteLine(endpoint.EndpointUrl);
                }

                Console.WriteLine("Press Enter to close the server");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
