using Ethereum.Wrapper;
using System;
using UnityEngine;

namespace Ethereum.Framework.Call
{
    public class PlayerDataCall : RequestAPI, ICallable
    {
        private void Start()
        {
            Call();
        }
        public async void Call()
        {
            Debug.Log("Calling player data...");

            try
            {
                var playerDataOutput = await contractHandler.QueryDeserializingToObjectAsync<GetPlayerDataFunction, GetPlayerDataOutputDTO>(
                    new GetPlayerDataFunction()
                );

                Debug.Log(playerDataOutput);
                Debug.Log(playerDataOutput.Name);
                Debug.Log(playerDataOutput.HighScore);
                Debug.Log(playerDataOutput.CurrentLevel);
                Debug.Log(playerDataOutput.LevelsCleared);
            } catch (Exception e) {
                Debug.Log(e.Message);
            }
        }
    }
}