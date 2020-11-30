using Ethereum.Singleton;
using UnityEngine;

namespace Core
{
    public class TotalUsers : MonoBehaviour
    {
        private async void Start()
        {
            int totalUsers = await Chitereum
                .instance
                .CallDataSource
                .TotalUsers();
            Debug.Log("TOTAL USERS:" + totalUsers);
        }
    }
}