using Ethereum;
using Ethereum.Wrapper;
using Nethereum.ABI.FunctionEncoding;
using Nethereum.Util;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System.Numerics;
using UnityEngine;

namespace Blockchain.Request
{
    public class SetNameRequest : MonoBehaviour
    {
        private void Start()
        {
            SetName();
        }
        public async void SetName()
        {
            Debug.Log("SetName()");

            var account = new Account(Environment.Account2PK);
            var web3 = new Web3(account, Environment.InfuraKey);
            
            try {
                var contractHandler = web3.Eth.GetContractHandler(Environment.contractAddress);
                var receipt = await contractHandler.SendRequestAndWaitForReceiptAsync(
                    new SetNameFunction() {
                        NewName = "Dennis"
                    }
                );

                if (receipt.TransactionHash.IsNotAnEmptyAddress()) {
                    Debug.Log("Successful");
                }
            }
            catch (SmartContractRevertException e) //TODO: not called why?
            {
                Debug.Log(e.Message);
            }
            catch (System.Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}