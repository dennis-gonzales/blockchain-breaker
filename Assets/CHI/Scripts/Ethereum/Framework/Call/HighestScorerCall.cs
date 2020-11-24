using Ethereum.Wrapper;
using System;
using UnityEngine;

namespace Ethereum.Framework.Call
{
    public class HighestScorerCall : RequestAPI, ICallable
    {
        private void Start()
        {
            Call();
        }
        public async void Call()
        {
            Debug.Log("Calling highscorer...");

            try
            {
                var highestScorerOutput = await contractHandler.QueryDeserializingToObjectAsync<GetHighestScorerFunction, GetHighestScorerOutputDTO>(
                new GetHighestScorerFunction()
            );

                Debug.Log(highestScorerOutput);
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}