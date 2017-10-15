using System;

using Microsoft.Azure.Devices;

namespace IoTHubService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var manager = RegistryManager.CreateFromConnectionString("");
            var twin = manager.GetTwinAsync("").Result;
        }
    }
}
