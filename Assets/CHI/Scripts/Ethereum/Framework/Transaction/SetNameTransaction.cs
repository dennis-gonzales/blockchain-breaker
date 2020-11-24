using Ethereum.Wrapper;
using Nethereum.ABI.FunctionEncoding;
using Nethereum.Util;
using System;
using UnityEngine;

namespace Ethereum.Framework.Transaction
{
    public class SetNameTransaction : RequestAPI, ITransactable
    {
        private void Start()
        {
            Transact();
        }
        public async void Transact()
        {
            Debug.Log("Setting the name...");
            
            try {
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
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}