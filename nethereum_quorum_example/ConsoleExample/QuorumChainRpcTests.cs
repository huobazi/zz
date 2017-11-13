using System;
using System.Collections.Generic;
using System.Text;
using Nethereum.Quorum;
using Nethereum.RPC.Eth.DTOs;

namespace ConsoleExample
{
    public sealed class QuorumChainRpcTests
    {
        public static async void Run()
        {
            Console.WriteLine("This is QuorumChainRpcTests:");

            string hash = string.Empty;
            var web3    = new Web3Quorum(DefaultSettings.GetDefaultUrl());

            var canonicalHash = await web3.Quorum.CanonicalHash.SendRequestAsync(1);
            Console.WriteLine("The canonicalHash is:");
            Console.WriteLine(canonicalHash);

            Console.WriteLine("###########################################");

            web3 = new Web3Quorum(DefaultSettings.GetDefaultUrl());
            var isBlockMaker = await web3.Quorum.IsBlockMaker.SendRequestAsync(await web3.Eth.CoinBase.SendRequestAsync());

            Console.WriteLine("The isBlockMaker will be true");
            Console.WriteLine(isBlockMaker);


            Console.WriteLine("###########################################");

            web3 = new Web3Quorum(DefaultSettings.GetDefaultUrl());
            var isVoter = await web3.Quorum.IsVoter.SendRequestAsync(await web3.Eth.CoinBase.SendRequestAsync());
            Console.WriteLine("The isVoter will be true");
            Console.WriteLine(isVoter);


            //Console.WriteLine("###########################################");
            ////Node2 is a Block Maker
            ////This might fail.. depending on the canonicalhash.. (quorum)            
            //web3 = new Web3Quorum(DefaultSettings.QuorumIPAddress + ":22001");
            //hash = await web3.Quorum.MakeBlock.SendRequestAsync();
            //Console.WriteLine(hash);


            //Console.WriteLine("###########################################");

            //web3 = new Web3Quorum(DefaultSettings.QuorumIPAddress + ":22004");
            //var block =
            //    await web3.Eth.Blocks.GetBlockWithTransactionsByNumber.SendRequestAsync(BlockParameter.CreateLatest());

            //hash = await web3.Quorum.Vote.SendRequestAsync(block.BlockHash);

            //Console.WriteLine(hash);


            Console.WriteLine("###########################################");

            //Node 2 is a BlockMaker

            web3 = new Web3Quorum(DefaultSettings.QuorumIPAddress + ":22001");
            await web3.Quorum.PauseBlockMaker.SendRequestAsync();
            await web3.Quorum.ResumeBlockMaker.SendRequestAsync();



            Console.WriteLine("###########################################");

            web3 = new Web3Quorum(DefaultSettings.QuorumIPAddress + ":22001");
            var nodeInfo = await web3.Quorum.NodeInfo.SendRequestAsync();

            Console.WriteLine("The node2 will be active");
            Console.WriteLine(nodeInfo.BlockMakeStratregy.Status);
        }

    }
}
