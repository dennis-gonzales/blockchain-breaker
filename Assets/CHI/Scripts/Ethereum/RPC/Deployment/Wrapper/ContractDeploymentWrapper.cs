using Ethereum.RPC.Deployment.Provider;
using Nethereum.Contracts;

namespace Ethereum.RPC.Deployment.Wrapper
{
    public class ContractDeploymentWrapper : ContractDeploymentMessage
    {
        public ContractDeploymentWrapper() : base(BytecodeProvider.Read())
        {

        }
    }
}