using Ethereum;
using Ethereum.Wrapper;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Nethereum.Util;
using UnityEngine;

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

            var ownerOutput = await contractHandler.QueryDeserializingToObjectAsync<GetOwnerFunction, GetOwnerOutputDTO>(
                new GetOwnerFunction()
            );

            Debug.Log(ownerOutput);
            Debug.Log($"is Valid: {ownerOutput.Owner.IsValidEthereumAddressHexFormat()}");
        }
    }
}