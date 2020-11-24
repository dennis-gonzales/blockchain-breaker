using Ethereum.Wrapper;
using Nethereum.ABI.FunctionEncoding;
using Nethereum.Util;
using System;
using System.Numerics;
using UnityEngine;

namespace Ethereum.Framework.Transaction
{
    public class SetScoreTransaction : RequestAPI, ITransactable
    {
        private void Start()
        {
            Transact();
        }
        public async void Transact()
        {
            Debug.Log("Setting the score...");
            
            try {
                var receipt = await contractHandler.SendRequestAndWaitForReceiptAsync(
                    new SetScoreFunction() {
                        NewScore = BigInteger.Parse("100")
                    }
                );

                if (receipt.Logs.HasValues) {
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
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}