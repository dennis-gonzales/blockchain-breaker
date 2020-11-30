using Ethereum.RPC.Deployment.Provider;
using Nethereum.Contracts;

namespace Ethereum.RPC.Deployment
{
    public class ContractDeployment : ContractDeploymentMessage
    {
        public ContractDeployment() : base(BytecodeProvider.Read())
        {

        }
    }
}