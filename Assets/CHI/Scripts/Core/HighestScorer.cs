using Ethereum.Singleton;
using UnityEngine;

namespace Core
{
    public class HighestScorer : MonoBehaviour
    {
        private async void Start()
        {
            string highestScorer = await Chitereum
                .instance
                .CallDataSource
                .HighestScorer();
            Debug.Log("HIGHEST SCORER:" + highestScorer);
        }
    }
}