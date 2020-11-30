using Ethereum.RPC.Wrapper;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Call.UseCase
{
    public class TotalUsersCall : Base, ICallable<int>
    {
        public async Task<int> Call()
        {
            Debug.Log("Calling users...");

            try
            {
                var totalUsersOutput = await contractHandler.QueryDeserializingToObjectAsync<GetTotalUsersFunction, GetTotalUsersOutputDTO>(
                    new GetTotalUsersFunction()
                );

                Debug.Log(totalUsersOutput);
                return (int)totalUsersOutput.TotalUsers;
            } catch (Exception e) {
                Debug.Log(e.Message);
                return 0;
            }
        }
    }
}