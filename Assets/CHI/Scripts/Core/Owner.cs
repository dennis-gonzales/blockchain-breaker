using Ethereum.Singleton;
using UnityEngine;

namespace Core
{
    public class Owner : MonoBehaviour
    {
        private async void Start()
        {
            string owner = await Chitereum
                .instance
                .CallDataSource
                .Owner();
            Debug.Log("OWNER ADDRESS:" + owner);
        }
    }
}