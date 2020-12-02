using Ethereum.RPC.Deployment.Deployer;
using System;
using System.Threading.Tasks;

namespace Ethereum.RPC.Deployment
{
    public class DeploymentRepository : DeploymentDataSource
    {
        private readonly Lazy<Web3ContractDeployer> web3Contract;

        public DeploymentRepository()
        {
            web3Contract = new Lazy<Web3ContractDeployer>();
        }

        public Task<Response> Web3Contract() => web3Contract.Value.Deploy();
    }
}
