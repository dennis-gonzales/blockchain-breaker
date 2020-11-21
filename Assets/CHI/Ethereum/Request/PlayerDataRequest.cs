using Ethereum;
using Nethereum.Web3;
using UnityEngine;
using Nethereum.Web3.Accounts;
using Ethereum.Wrapper;

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

            // var playerDataHandler = web3.Eth.GetContractQueryHandler<PlayerData.GetPlayerDataFunction>();
            // var playerDataOutput = await playerDataHandler.QueryDeserializingToObjectAsync<PlayerData.GetPlayerDataOutputDTO>
            // (
            //     new PlayerData.GetPlayerDataFunction(),
            //     Environment.contractAddress
            // );

            var playerDataOutput = await contractHandler.QueryDeserializingToObjectAsync
            <PlayerData.GetPlayerDataFunction, PlayerData.GetPlayerDataOutputDTO>
            (
                new PlayerData.GetPlayerDataFunction()
            );


            Debug.Log(playerDataOutput);
            Debug.Log(playerDataOutput.HighScore);
            Debug.Log(playerDataOutput.CurrentLevel);
            Debug.Log(playerDataOutput.LevelsCleared);
        }
    }
}