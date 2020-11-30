using Ethereum.Singleton;
using UnityEngine;

public class AddPlayer : MonoBehaviour
{
    private async void Start()
    {
        await Chitereum
                .instance
                .TransactionDataSource
                .AddPlayer();
    }
}
