using Ethereum.Singleton;
using UnityEngine;

namespace Core
{
    public class HighestScorer : MonoBehaviour
    {
        private async void Start()
        {
            var highestScorer = await Chitereum
                .instance
                .CallDataSource
                .HighestScorer();
            Debug.Log("HIGHEST SCORER:" + highestScorer.PlayerAddress);
        }
    }
}