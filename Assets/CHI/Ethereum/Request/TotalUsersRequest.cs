using Ethereum;
using Ethereum.Wrapper;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using UnityEngine;

namespace Blockchain.Request
{
    public class TotalUsersRequest : MonoBehaviour
    {
        private void Start()
        {
            GetUsers();
        }

        public async void GetUsers()
        {
            Debug.Log("GetUsers()");

            var account = new Account(Environment.Account2PK);
            var web3 = new Web3(account, Environment.InfuraKey);
            var contractHandler = web3.Eth.GetContractHandler(Environment.contractAddress);

            var totalUsersOutput = await contractHandler.QueryDeserializingToObjectAsync<GetTotalUsersFunction, GetTotalUsersOutputDTO>(
                new GetTotalUsersFunction()
            );

            Debug.Log(totalUsersOutput);
        }
        
    }
}