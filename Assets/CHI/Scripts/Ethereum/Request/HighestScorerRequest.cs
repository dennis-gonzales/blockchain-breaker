﻿using Ethereum;
using Ethereum.Wrapper;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using UnityEngine;

namespace Blockchain.Request
{
    public class HighestScorerRequest : MonoBehaviour
    {
        private void Start()
        {
            GetHighestScorer();
        }
        public async void GetHighestScorer()
        {
            Debug.Log("GetHighestScorer()");

            var account = new Account(Env.Account2PK);
            var web3 = new Web3(account, Env.InfuraKey);
            var contractHandler = web3.Eth.GetContractHandler(Env.contractAddress);

            var highestScorerOutput = await contractHandler.QueryDeserializingToObjectAsync<GetHighestScorerFunction, GetHighestScorerOutputDTO>(
                new GetHighestScorerFunction()
            );

            Debug.Log(highestScorerOutput);
        }
    }
}