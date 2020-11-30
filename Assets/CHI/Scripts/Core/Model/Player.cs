using Ethereum.RPC.Call.Wrapper;
using System.Numerics;
using UnityEngine;

namespace Core.Model
{
    [SerializeField]
    public class Player
    {
        [SerializeField]
        public string name;

        [SerializeField]
        public string ethereumAddress;

        [SerializeField]
        public BigInteger highScore;

        public void ToPlayer(GetPlayerDataOutputDTO playerData)
        {
            name = playerData.Name;
            highScore = playerData.HighScore;
        }
    }
}