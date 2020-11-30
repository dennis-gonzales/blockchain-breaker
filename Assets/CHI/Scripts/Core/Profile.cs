using Core.Model;
using Ethereum.Singleton;
using UnityEngine;

namespace Core
{
    public class Profile : MonoBehaviour
    {

        private readonly Player player = new Player();

        private async void Start()
        {
            var playerData = await Chitereum
                .instance
                .CallDataSource
                .PlayerData();

            player.ToPlayer(playerData);

            Debug.Log(player.name);
            Debug.Log(player.highScore);
        }
    }
}