using Ethereum.RPC.Wrapper;
using Nethereum.Util;
using System;
using System.Numerics;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Transaction.UseCase
{
    public class SetScoreTransaction : Base, ITransactable<Response>
    {
        public async Task<Response> Transact()
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

                return new Response(succeeded: true);
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return new Response(exception: e);
            }
        }
    }
}