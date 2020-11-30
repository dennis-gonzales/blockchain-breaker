using Ethereum.RPC.Call.Wrapper;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Call.UseCase
{
    public class HighestScorerCall : Base, ICallable<GetHighestScorerOutputDTO>
    {
        public async Task<GetHighestScorerOutputDTO> Call()
        {
            Debug.Log("Calling highscorer...");

            try
            {
                var highestScorerOutput = await contractHandler.QueryDeserializingToObjectAsync<GetHighestScorerFunction, GetHighestScorerOutputDTO>(
                new GetHighestScorerFunction()
            );

                Debug.Log(highestScorerOutput);
                return highestScorerOutput;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return null;
            }
        }
    }
}