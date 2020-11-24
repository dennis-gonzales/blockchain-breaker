using Ethereum.Wrapper;
using System;
using UnityEngine;

namespace Ethereum.Framework.Call
{
    public class TotalUsersCall : RequestAPI, ICallable
    {
        private void Start()
        {
            Call();
        }

        public async void Call()
        {
            Debug.Log("Calling users...");

            try
            {
                var totalUsersOutput = await contractHandler.QueryDeserializingToObjectAsync<GetTotalUsersFunction, GetTotalUsersOutputDTO>(
                    new GetTotalUsersFunction()
                );

                Debug.Log(totalUsersOutput);
            } catch (Exception e) {
                Debug.Log(e.Message);
            }
        }
    }
}