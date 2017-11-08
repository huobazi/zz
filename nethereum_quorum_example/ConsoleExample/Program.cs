using System;

namespace ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        

        private static void Run()
        {
            var ipAddress = DefaultSettings.QuorumIPAddress;
            var node1Port = "22000";
            var node2Port = "22001";
            var node7Port = "22006";
            var urlNode1 = ipAddress + ":" + node1Port;
            var urlNode2 = ipAddress + ":" + node2Port;
            var urlNode7 = ipAddress + ":" + node7Port;

            var address = "0x1932c48b2bf8102ba33b4a6b545c32236e342f34";
        }
    }
}