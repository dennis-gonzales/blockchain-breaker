using Ethereum.RPC.Transaction.Wrapper;
using Nethereum.Util;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Transaction.UseCase
{
    public class SetNameTransaction : Base, ITransactable<Response>
    {
        public async Task<Response> Transact()
        {
            Debug.Log("Setting the name...");
            
            try {
                var receipt = await contractHandler.SendRequestAndWaitForReceiptAsync(
                    new SetNameFunction() {
                        NewName = "Dennis"
                    }
                );

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