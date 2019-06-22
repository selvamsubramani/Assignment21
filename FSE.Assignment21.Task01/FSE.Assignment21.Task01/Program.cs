using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace FSE.Assignment21.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Http Uri
            var http = new Uri("http://localhost:1000/TestService");
            //TCP Uri
            var tcp = new Uri("net.tcp://localhost:2000/TestService");

            //Service Host
            ServiceHost host = new ServiceHost(typeof(SelfHostingService), http, tcp);
            //Add bindings
            host.AddServiceEndpoint(typeof(ISelfHostingService), new BasicHttpBinding(), http);
            host.AddServiceEndpoint(typeof(ISelfHostingService), new NetTcpBinding(), tcp);
            //Behavior
            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior { HttpGetEnabled = true };
            host.Description.Behaviors.Add(behavior);
            //mex
            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");
            //Launch the service
            host.Open();

            Console.WriteLine($"Service is hosted at {DateTime.Now}");
            Console.WriteLine($"Http service url: {http}");
            Console.WriteLine($"TCP service url: {tcp}");
            Console.WriteLine("Service is running...");
            Console.Read();
        }
    }
}