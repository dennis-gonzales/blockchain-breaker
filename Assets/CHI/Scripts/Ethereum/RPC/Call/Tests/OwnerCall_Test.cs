using Ethereum.RPC.Call.Wrapper;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Util;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Call.Tests
{
    public abstract class BaseTest
    {
        protected static Account account => new Account(Env.Account2PK);
        protected static Web3 web3 => new Web3(account, Env.InfuraKey);
        protected static ContractHandler contractHandler => web3.Eth.GetContractHandler(Env.contractAddress);

        protected T RunAsyncMethodSync<T>(Func<Task<T>> asyncFunc)
        {
            return Task.Run(async () => await asyncFunc()).GetAwaiter().GetResult();
        }
        protected void RunAsyncMethodSync(Func<Task> asyncFunc)
        {
            Task.Run(async () => await asyncFunc()).GetAwaiter().GetResult();
        }
    }

    public class OwnerCall_Test : BaseTest
    {
        [Test]
        public void Test()
        {
            var result = RunAsyncMethodSync(() => GetOwnerAsync());
            Assert.AreEqual(result, "0x72c9ad981f085a37b2846c0d5d55733b3542e716");
        }

        public async Task<string> GetOwnerAsync()
        {
            try
            {
                var ownerOutput = await contractHandler.QueryDeserializingToObjectAsync<GetOwnerFunction, GetOwnerOutputDTO>(
                new GetOwnerFunction()
            );

                Debug.Log(ownerOutput);
                Debug.Log($"is Valid: {ownerOutput.Owner.IsValidEthereumAddressHexFormat()}");
                return ownerOutput.Owner;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return e.Message;
            }

        }

        [Test]
        public void Testthrow()
        {
            Assert.Throws<InvalidOperationException>(
                           () => RunAsyncMethodSync(() => ThrowTaskAsync(4)));
        }

        public async Task<int> ThrowTaskAsync(int a)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(200));
            throw new InvalidOperationException();
        }
    }
}
