using Ethereum.RPC.Wrapper;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Call.UseCase
{
    public class OwnerCall : Base, ICallable<string>
    {
        public async Task<string> Call()
        {
            Debug.Log("Calling owner...");

            try
            {
                var ownerOutput = await contractHandler.QueryDeserializingToObjectAsync<GetOwnerFunction, GetOwnerOutputDTO>(
                new GetOwnerFunction()
            );

                //Debug.Log($"is Valid: {ownerOutput.Owner.IsValidEthereumAddressHexFormat()}");

                return ownerOutput.Owner;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return e.Message;
            }
        }
    }
}