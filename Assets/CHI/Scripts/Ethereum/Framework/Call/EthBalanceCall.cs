using Nethereum.Web3;
using System;
using UnityEngine;

namespace Ethereum.Framework.Call
{
    public class EthBalanceCall : RequestAPI, ICallable
    {
        private void Start()
        {
            Call();
        }

        public async void Call()
        {
            Debug.Log("Calling ETH balance...");

            try
            {
                var balance = await web3.Eth.GetBalance.SendRequestAsync(Env.Account2);

                Debug.Log("Balance: " + Web3.Convert.FromWei(balance.Value));
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}