using Ethereum.Singleton;
using UnityEngine;

public class SetScore : MonoBehaviour
{
    private async void Start()
    {
        await Chitereum
                .instance
                .TransactionDataSource
                .SetScore();
    }
}
