using Nethereum.Web3;
using System;
using System.Numerics;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Call.UseCase
{
    public class EthBalanceCall : Base, ICallable<BigInteger>
    {
        public async Task<BigInteger> Call()
        {
            Debug.Log("Calling ETH balance...");

            try
            {
                var balance = await web3.Eth.GetBalance.SendRequestAsync(Env.Account2);

                Debug.Log("Balance: " + Web3.Convert.FromWei(balance.Value));
                return balance;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return 0;
            }
        }
    }
}