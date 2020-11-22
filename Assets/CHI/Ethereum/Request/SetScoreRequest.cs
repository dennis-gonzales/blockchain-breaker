using Ethereum;
using Ethereum.Wrapper;
using Nethereum.ABI.FunctionEncoding;
using Nethereum.Util;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System.Numerics;
using UnityEngine;

namespace Blockchain.Request
{
    public class SetScoreRequest : MonoBehaviour
    {
        private void Start()
        {
            SetScore();
        }
        public async void SetScore()
        {
            Debug.Log("SetScore()");

            var account = new Account(Environment.Account2PK);
            var web3 = new Web3(account, Environment.InfuraKey);
            
            try {
                var contractHandler = web3.Eth.GetContractHandler(Environment.contractAddress);
                var receipt = await contractHandler.SendRequestAndWaitForReceiptAsync(
                    new SetScoreFunction()
                    {
                        NewScore = BigInteger.Parse("100")
                    }
                );

                if (receipt.Logs.HasValues)
                {
                    var highScoreAchievedEvent = contractHandler.GetEvent<HighScoreAchievedEventDTO>();
                    var eventOutputs = highScoreAchievedEvent.DecodeAllEventsForEvent(receipt.Logs);
                    var playerHighScore = eventOutputs[0].Event.NewHighScore;
                    var playerAddress = eventOutputs[0].Event.Player;

                    Debug.Log(playerHighScore);
                    Debug.Log(playerAddress);
                }

                Debug.Log(receipt.Logs);
                

                if (receipt.TransactionHash.IsNotAnEmptyAddress()) {
                    Debug.Log("Successful");
                }
            }
            catch (SmartContractRevertException e) //TODO: not called why?
            {
                Debug.Log(e.Message);
            }
            catch (System.Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}