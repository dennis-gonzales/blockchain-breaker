using Ethereum;
using Nethereum.Web3;
using UnityEngine;
using Nethereum.Web3.Accounts;
using Ethereum.Wrapper;

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

            var account = new Account(Environment.Account2PK);
            var web3 = new Web3(account, Environment.InfuraKey);
            var contractHandler = web3.Eth.GetContractHandler(Environment.contractAddress);

            var highestScorerOutput = await contractHandler.QueryDeserializingToObjectAsync
            <HighestScorer.GetHighestScorerFunction, HighestScorer.GetHighestScorerOutputDTO>
            (
                new HighestScorer.GetHighestScorerFunction()
            );


            Debug.Log(highestScorerOutput);
        }
    }
}