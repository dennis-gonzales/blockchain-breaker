using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContractManager : MonoBehaviour
{
    private void Start()
    {
        var deployer = GetComponent<IDeployable>();

        if (deployer is IDeployable) {
            Debug.Log("Deploying...");
            deployer.Deploy();
        } else {
            Debug.LogWarning("Error deploying contract...");
        }
    }
}
