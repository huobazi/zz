﻿using System;
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
            Console.WriteLine("Hello World!");
            Run();
            Console.ReadLine();
        }
        

        private static async void Run()
        {
            var ipAddress = DefaultSettings.QuorumIPAddress;
            var node1Port = "22000";
            var node2Port = "22001";
            var node7Port = "22006";
            var urlNode1 = ipAddress + ":" + node1Port;
            var urlNode2 = ipAddress + ":" + node2Port;
            var urlNode7 = ipAddress + ":" + node7Port;

            var address = "0x1932c48b2bf8102ba33b4a6b545c32236e342f34";
            var abi = "[{ 'constant':true,'inputs':[],'name':'storedData','outputs':[{'name':'','type':'uint256'}],'payable':false,'type':'function'},{'constant':false,'inputs':[{'name':'newVal','type':'uint256'}],'name':'set','outputs':[],'payable':false,'type':'function'},{'constant':true,'inputs':[],'name':'get','outputs':[{'name':'retVal','type':'uint256'}],'payable':false,'type':'function'},{'inputs':[{'name':'initVal','type':'uint256'}],'type':'constructor'}]";


            var web3Node1 = new Web3Quorum(urlNode1);
            var transactionService = new TransactionReceiptPollingService(web3Node1.TransactionManager);
            var account = await web3Node1.Eth.CoinBase.SendRequestAsync();
            var contract = web3Node1.Eth.GetContract(abi, address);
            var functionSet = contract.GetFunction("set");

            //set the private for
            var privateFor = new List<string>(new[] { "ROAZBWtSacxXQrOe3FGAqJDyJjFePR5ce4TSIzmJ0Bc=" });
            web3Node1.SetPrivateRequestParameters(privateFor);
            //send transaction
            var txnHash = await transactionService.SendRequestAsync(() => functionSet.SendTransactionAsync(account, 400));

            var node1Value = await GetValue(abi, address, urlNode1);
            Console.WriteLine(node1Value);

            var node2Value = await GetValue(abi, address, urlNode2);
            Console.WriteLine(node2Value);

            var node7Value = await GetValue(abi, address, urlNode7);
            Console.WriteLine(node7Value);

            txnHash = await transactionService.SendRequestAsync(() => functionSet.SendTransactionAsync(account, 420));

            //node1
            node1Value = await GetValue(abi, address, urlNode1);
            Console.WriteLine(node1Value);

            node2Value = await GetValue(abi, address, urlNode2);
            Console.WriteLine(node2Value);

            node7Value = await GetValue(abi, address, urlNode7);
            Console.WriteLine(node7Value);

        }

        private static async Task<int> GetValue(string abi, string address, string nodeUrl)
        {
            //normal geth is ok
            var web3 = new Web3(nodeUrl);
            var contract = web3.Eth.GetContract(abi, address);
            var functionGet = contract.GetFunction("get");
            return await functionGet.CallAsync<int>();
        }
    }
}