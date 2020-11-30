using Ethereum.RPC.Call.Wrapper;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Call.UseCase
{
    public class PlayerDataCall : Base, ICallable<GetPlayerDataOutputDTO>
    {

        public async Task<GetPlayerDataOutputDTO> Call()
        {
            Debug.Log("Calling player data...");

            try
            {
                var playerDataOutput = await contractHandler.QueryDeserializingToObjectAsync<GetPlayerDataFunction, GetPlayerDataOutputDTO>(
                    new GetPlayerDataFunction()
                );

                return playerDataOutput;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return null;
            }
        }
    }
}