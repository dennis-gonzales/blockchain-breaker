using Ethereum.Singleton;
using UnityEngine;

namespace Core
{
    public class TotalUsers : MonoBehaviour
    {
        private async void Start()
        {
            var totalUsers = await Chitereum
                .instance
                .CallDataSource
                .TotalUsers();
            Debug.Log("TOTAL USERS:" + totalUsers.TotalUsers);
        }
    }
}