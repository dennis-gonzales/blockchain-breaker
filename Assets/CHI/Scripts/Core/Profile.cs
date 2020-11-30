using Core.Model;
using Ethereum.Singleton;
using UnityEngine;

namespace Core
{
    public class Profile : MonoBehaviour
    {

        private Player player;

        private void Start()
        {
            Chitereum
                .instance
                .CallDataSource
                .PlayerData();
        }
    }
}