using System;
using System.Threading.Tasks;
using Ethereum.RPC.Call.Wrapper;
using Ethereum.RPC.Deployment.Wrapper;
using UnityEngine;

namespace Ethereum.RPC.Deployment.Deployer
{
    public class Web3ContractDeployer : Base, IDeployable<Response>
    {
        public async Task<Response> Deploy()
        {
            try
            {
                var deploymentHandler = web3.Eth.GetContractDeploymentHandler<ContractDeploymentWrapper>();
                var deploymentReceipt = await deploymentHandler.SendRequestAndWaitForReceiptAsync(
                    new ContractDeploymentWrapper()
                );

                var contractAddress = deploymentReceipt.ContractAddress;
                Debug.Log($"Blockchain Breaker deployed with tx: {contractAddress}");

                var contractHandler = web3.Eth.GetContractHandler(contractAddress);
                var ownerOutput = await contractHandler.QueryDeserializingToObjectAsync<GetOwnerFunction, GetOwnerOutputDTO>(
                    new GetOwnerFunction()
                );

                Debug.Log(ownerOutput);

                return new Response(succeeded: true);

            }
            catch (Exception e)
            {
                Debug.Log(e);
                return new Response(exception: e);
            }
        }
    }
}