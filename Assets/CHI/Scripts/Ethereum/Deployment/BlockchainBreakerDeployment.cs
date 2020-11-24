using Ethereum.Deployment.Deployer.Provider;
using Nethereum.Contracts;

namespace Ethereum.Deployment
{
    public class BlockchainBreakerDeployment : ContractDeploymentMessage
    {
        public BlockchainBreakerDeployment() : base(BytecodeProvider.Read())
        {

        }
    }
}