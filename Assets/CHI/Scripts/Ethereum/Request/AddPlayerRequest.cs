using System;
using Ethereum;
using Ethereum.Wrapper;
using Nethereum.ABI.FunctionEncoding;
using Nethereum.Util;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using UnityEngine;

namespace Blockchain.Request
{
    public class AddPlayerRequest : MonoBehaviour
    {
        private void Start()
        {
            AddPlayer();
        }
        public async void AddPlayer()
        {
            Debug.Log("AddPlayer()");

            var account = new Account(Env.Account2PK);
            var web3 = new Web3(account, Env.InfuraKey);
            
            try {
                var contractHandler = web3.Eth.GetContractHandler(Env.contractAddress);
                var receipt = await contractHandler.SendRequestAndWaitForReceiptAsync(
                    new AddPlayerFunction() {
                        PlayerName = "CHI"
                    }
                );

                Debug.Log(receipt.Logs);
                Debug.Log(receipt.Status);
                Debug.Log(receipt.TransactionHash);

                if (receipt.TransactionHash.IsNotAnEmptyAddress()) {
                    Debug.Log("Successful");
                }
            }
            catch (SmartContractRevertException e) //TODO: not called why?
            {
                Debug.Log(e.Message);
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}