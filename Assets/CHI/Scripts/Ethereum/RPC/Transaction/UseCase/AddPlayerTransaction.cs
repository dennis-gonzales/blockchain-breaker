using System;
using System.Threading.Tasks;
using Ethereum.RPC.Wrapper;
using Nethereum.Util;
using UnityEngine;

namespace Ethereum.RPC.Transaction.UseCase
{
    public class AddPlayerTransaction : Base, ITransactable<Response>
    {
        public async Task<Response> Transact()
        {
            Debug.Log("Adding player...");
            
            try {
                var receipt = await contractHandler.SendRequestAndWaitForReceiptAsync(
                    new AddPlayerFunction() {
                        PlayerName = "CHI"
                    }
                );

                Debug.Log(receipt.Logs);
                Debug.Log(receipt.Status);
                Debug.Log(receipt.TransactionHash);

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