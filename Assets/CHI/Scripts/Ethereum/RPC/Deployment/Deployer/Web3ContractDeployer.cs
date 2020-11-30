using System;
using Ethereum.RPC.Wrapper;
using Nethereum.ABI.FunctionEncoding;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using UnityEngine;

namespace Ethereum.RPC.Deployment.Deployer
{
    public class Web3ContractDeployer : MonoBehaviour, IDeployable
    {
        public async void Deploy()
        {
            var account = new Account(Env.Account2PK);
            var web3 = new Web3(account, Env.InfuraKey);

            try
            {
                var deploymentHandler = web3.Eth.GetContractDeploymentHandler<ContractDeployment>();
                var deploymentReceipt = await deploymentHandler.SendRequestAndWaitForReceiptAsync(
                    new ContractDeployment()
                );

                var contractAddress = deploymentReceipt.ContractAddress;
                Debug.Log($"Blockchain Breaker deployed with tx: {contractAddress}");

                var contractHandler = web3.Eth.GetContractHandler(contractAddress);
                var ownerOutput = await contractHandler.QueryDeserializingToObjectAsync<GetOwnerFunction, GetOwnerOutputDTO>(
                    new GetOwnerFunction()
                );

                Debug.Log(ownerOutput);

            }
            catch (SmartContractRevertException e)
            {
                Debug.Log(e);
            }
            catch (Exception e)
            {
                Debug.Log(e);
            }
        }
    }
}