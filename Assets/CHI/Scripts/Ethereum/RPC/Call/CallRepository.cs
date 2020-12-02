using Ethereum.RPC.Call.UseCase;
using Ethereum.RPC.Call.Wrapper;
using System;
using System.Numerics;
using System.Threading.Tasks;

namespace Ethereum.RPC.Call
{
    public class CallRepository : CallDataSource
    {
        private readonly Lazy<EthBalanceCall> ethBalance;
        private readonly Lazy<HighestScorerCall> highestScorer;
        private readonly Lazy<OwnerCall> owner;
        private readonly Lazy<PlayerDataCall> playerData;
        private readonly Lazy<TotalUsersCall> totalUsers;

        public CallRepository()
        {
            ethBalance = new Lazy<EthBalanceCall>();
            highestScorer = new Lazy<HighestScorerCall>();
            owner = new Lazy<OwnerCall>();
            playerData = new Lazy<PlayerDataCall>();
            totalUsers = new Lazy<TotalUsersCall>();
        }

        public Task<BigInteger> EthBalance() => ethBalance.Value.Call();

        public Task<GetHighestScorerOutputDTO> HighestScorer() => highestScorer.Value.Call();

        public Task<GetOwnerOutputDTO> Owner() => owner.Value.Call();

        public Task<GetPlayerDataOutputDTO> PlayerData() => playerData.Value.Call();

        public Task<GetTotalUsersOutputDTO> TotalUsers() => totalUsers.Value.Call();
    }
}