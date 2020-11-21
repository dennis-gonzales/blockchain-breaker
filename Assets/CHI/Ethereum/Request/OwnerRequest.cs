using Ethereum;
using Nethereum.Web3;
using UnityEngine;
using Nethereum.Web3.Accounts;
using Ethereum.Wrapper;

namespace Blockchain.Request
{
    public class OwnerRequest : MonoBehaviour
    {
        private void Start()
        {
            GetOwner();
        }
        public async void GetOwner()
        {
            Debug.Log("GetOwner()");

            var account = new Account(Environment.Account2PK);
            var web3 = new Web3(account, Environment.InfuraKey);
            var contractHandler = web3.Eth.GetContractHandler(Environment.contractAddress);

            var ownerHandler = web3.Eth.GetContractQueryHandler<Owner.GetOwnerFunction>();
            var ownerOutput = await ownerHandler.QueryDeserializingToObjectAsync<Owner.GetOwnerOutputDTO>
            (
                new Owner.GetOwnerFunction(),
                Environment.contractAddress
            );


            Debug.Log(ownerOutput);
        }
    }
}