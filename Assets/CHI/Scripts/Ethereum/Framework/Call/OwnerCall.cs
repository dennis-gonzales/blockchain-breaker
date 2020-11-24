using Ethereum.Wrapper;
using Nethereum.Util;
using System;
using UnityEngine;

namespace Ethereum.Framework.Call
{
    public class OwnerCall : RequestAPI, ICallable
    {
        private void Start()
        {
            Call();
        }
        public async void Call()
        {
            Debug.Log("Calling owner...");

            try
            {
                var ownerOutput = await contractHandler.QueryDeserializingToObjectAsync<GetOwnerFunction, GetOwnerOutputDTO>(
                new GetOwnerFunction()
            );

                Debug.Log(ownerOutput);
                Debug.Log($"is Valid: {ownerOutput.Owner.IsValidEthereumAddressHexFormat()}");
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}