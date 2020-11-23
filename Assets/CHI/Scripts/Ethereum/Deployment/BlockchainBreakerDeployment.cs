using Nethereum.Contracts;

public class BlockchainBreakerDeployment : ContractDeploymentMessage
{
    public BlockchainBreakerDeployment() : base(BytecodeProvider.Read())
    {
        
    }
}