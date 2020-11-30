using Ethereum.Singleton;
using System.Numerics;
using UnityEngine;

namespace Core
{
    public class EthBalance : MonoBehaviour
    {
        private async void Start()
        {
            BigInteger balance = await Chitereum
                .instance
                .CallDataSource
                .EthBalance();
            Debug.Log("BALANCE:" + balance);
        }
    }
}