using Nethereum.Contracts.ContractHandlers;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;

namespace Ethereum.RPC
{
    public abstract class Base
    {
        protected static Account account => new Account(Env.Account2PK);
        protected static Web3 web3 => new Web3(account, Env.InfuraKey);
        protected static ContractHandler contractHandler => web3.Eth.GetContractHandler(Env.contractAddress);
    }
}