using Ethereum.RPC.Call.Wrapper;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Ethereum.RPC.Call.UseCase
{
    public class TotalUsersCall : Base, ICallable<GetTotalUsersOutputDTO>
    {
        public async Task<GetTotalUsersOutputDTO> Call()
        {
            Debug.Log("Calling users...");

            try
            {
                var totalUsersOutput = await contractHandler.QueryDeserializingToObjectAsync<GetTotalUsersFunction, GetTotalUsersOutputDTO>(
                    new GetTotalUsersFunction()
                );

                return totalUsersOutput;
            } catch (Exception e) {
                Debug.Log(e.Message);
                return null;
            }
        }
    }
}