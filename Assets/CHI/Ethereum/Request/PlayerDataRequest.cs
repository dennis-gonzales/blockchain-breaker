using Ethereum;
using Ethereum.Wrapper;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using UnityEngine;

namespace Blockchain.Request
{
    public class PlayerDataRequest : MonoBehaviour
    {
        private void Start()
        {
            GetPlayerData();
        }
        public async void GetPlayerData()
        {
            Debug.Log("GetPlayerData()");

            var account = new Account(Environment.Account2PK);
            var web3 = new Web3(account, Environment.InfuraKey);
            var contractHandler = web3.Eth.GetContractHandler(Environment.contractAddress);

            var playerDataOutput = await contractHandler.QueryDeserializingToObjectAsync<GetPlayerDataFunction, GetPlayerDataOutputDTO>(
                new GetPlayerDataFunction()
            );

            Debug.Log(playerDataOutput);
            Debug.Log(playerDataOutput.Name);
            Debug.Log(playerDataOutput.HighScore);
            Debug.Log(playerDataOutput.CurrentLevel);
            Debug.Log(playerDataOutput.LevelsCleared);
        }
    }
}