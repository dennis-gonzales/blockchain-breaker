using System;
using Ethereum.Wrapper;
using Nethereum.ABI.FunctionEncoding;
using Nethereum.Util;
using UnityEngine;

namespace Ethereum.Framework.Transaction
{
    public class AddPlayerTransaction : RequestAPI, ITransactable
    {
        private void Start()
        {
            Transact();
        }
        public async void Transact()
        {
            Debug.Log("Adding player...");
            
            try {
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