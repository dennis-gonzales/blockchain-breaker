using Ethereum.RPC.Call.Wrapper;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Call.UseCase
{
    public class OwnerCall : Base, ICallable<GetOwnerOutputDTO>
    {
        public async Task<GetOwnerOutputDTO> Call()
        {
            Debug.Log("Calling owner...");

            try
            {
                var ownerOutput = await contractHandler.QueryDeserializingToObjectAsync<GetOwnerFunction, GetOwnerOutputDTO>(
                    new GetOwnerFunction()
                );

                return ownerOutput;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return null;
            }
        }
    }
}