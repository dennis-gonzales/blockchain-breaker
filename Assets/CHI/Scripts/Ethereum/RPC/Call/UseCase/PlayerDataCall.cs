using Ethereum.RPC.Wrapper;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Call.UseCase
{
    public class PlayerDataCall : Base, ICallable<string>
    {

        public async Task<string> Call()
        {
            Debug.Log("Calling player data...");

            try
            {
                var playerDataOutput = await contractHandler.QueryDeserializingToObjectAsync<GetPlayerDataFunction, GetPlayerDataOutputDTO>(
                    new GetPlayerDataFunction()
                );

                Debug.Log(playerDataOutput);
                Debug.Log(playerDataOutput.Name);

                return playerDataOutput.Name;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return e.Message;
            }
        }
    }
}