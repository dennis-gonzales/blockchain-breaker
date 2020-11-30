using Ethereum.RPC.Wrapper;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Call.UseCase
{
    public class HighestScorerCall : Base, ICallable<string>
    {
        public async Task<string> Call()
        {
            Debug.Log("Calling highscorer...");

            try
            {
                var highestScorerOutput = await contractHandler.QueryDeserializingToObjectAsync<GetHighestScorerFunction, GetHighestScorerOutputDTO>(
                new GetHighestScorerFunction()
            );

                Debug.Log(highestScorerOutput);
                return highestScorerOutput.PlayerAddress;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return e.Message;
            }
        }
    }
}