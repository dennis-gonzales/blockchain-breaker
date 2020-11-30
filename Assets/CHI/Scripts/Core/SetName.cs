using Ethereum.Singleton;
using UnityEngine;

public class SetName : MonoBehaviour
{
    private async void Start()
    {
        await Chitereum
                .instance
                .TransactionDataSource
                .SetName();
    }
}
