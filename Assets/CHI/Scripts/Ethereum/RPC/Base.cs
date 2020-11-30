using Nethereum.Contracts.ContractHandlers;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;

namespace Ethereum.RPC
{
    public abstract class Base
    {
        protected static Account account => new Account("755333b290b2196c3cf5e66f569ba7acc6975a8e3fb680eae7f3ac01a7886244");
        protected static Web3 web3 => new Web3(account);
        protected static ContractHandler contractHandler => web3.Eth.GetContractHandler("0x850adee4d9933df9d20aaf9b40a302b7471acb1d");

        public Base()
        {
            // TODO: check build config to adapt usages
        }
    }
}