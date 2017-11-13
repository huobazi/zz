using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nethereum.Quorum;
using Nethereum.RPC.TransactionReceipts;
using Nethereum.Web3;

namespace ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {

            QuorumChainRpcTests.Run();

            QuorumPrivateContractTests.Run();

            Console.ReadLine();
        }

        
    }
}
