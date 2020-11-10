using System;

namespace UDPProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyWorker worker = new ProxyWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
