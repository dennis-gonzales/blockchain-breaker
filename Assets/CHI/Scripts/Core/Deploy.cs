using Ethereum.Singleton;
using UnityEngine;

public class Deploy : MonoBehaviour
{
    private async void Start()
    {
        var rsp = await Chitereum
                .instance
                .DeploymentDataSource
                .Web3Contract();


        Debug.Log(rsp.Succeeded);
    }
}
