using Ethereum.RPC.Deployment.Deployer;
using UnityEngine;

namespace Ethereum.Manager
{
    public class ContractManager : MonoBehaviour
    {
        private void Start()
        {
            var deployer = GetComponent<IDeployable>();

            if (deployer is IDeployable)
            {
                Debug.Log("Deploying...");
                deployer.Deploy();
            }
            else
            {
                Debug.LogWarning("Error deploying contract...");
            }
        }
    }

}