using Nethereum.Contracts.ContractHandlers;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using UnityEngine;

namespace Ethereum.Framework
{   
    public abstract class RequestAPI : MonoBehaviour
    {
        protected static Account account => new Account(Env.Account2PK);
        protected static Web3 web3 => new Web3(account, Env.InfuraKey);
        protected static ContractHandler contractHandler => web3.Eth.GetContractHandler(Env.contractAddress);
    }
}