using System.ServiceModel;
using wcfExamples.Services;
using System;
namespace wcfExamples.ConsoleHost
{
    class Program
    {
        static void Main()
        {
            ServiceHost host = new ServiceHost(typeof(BookManager));
            host.Open();
            Console.WriteLine("Services started. Press [Enter] to exit.");
            Console.ReadLine();
            host.Close();
        }
    }
}
