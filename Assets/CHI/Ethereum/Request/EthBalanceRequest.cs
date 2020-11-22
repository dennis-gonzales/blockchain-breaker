﻿using Ethereum;
using Nethereum.Web3;
using UnityEngine;

namespace Blockchain.Request
{
    public class EthBalanceRequest : MonoBehaviour
    {
        private void Start()
        {
            GetEthBalance();
        }

        public async void GetEthBalance()
        {
            Debug.Log("GetEthBalance()");

            var web3 = new Web3(Environment.InfuraKey);
            var balance = await web3.Eth.GetBalance.SendRequestAsync(Environment.Account2);

            Debug.Log("Balance: " + Web3.Convert.FromWei(balance.Value));
        }
    }
}