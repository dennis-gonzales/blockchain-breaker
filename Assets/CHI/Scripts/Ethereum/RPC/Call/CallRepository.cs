using Ethereum.RPC.Call.UseCase;
using Ethereum.RPC.Call.Wrapper;
using System.Numerics;
using System.Threading.Tasks;

namespace Ethereum.RPC.Call
{
    public class CallRepository : CallDataSource
    {
        private readonly EthBalanceCall ethBalance;
        private readonly HighestScorerCall highestScorer;
        private readonly OwnerCall owner;
        private readonly PlayerDataCall playerData;
        private readonly TotalUsersCall totalUsers;

        public CallRepository()
        {
            ethBalance = new EthBalanceCall();
            highestScorer = new HighestScorerCall();
            owner = new OwnerCall();
            playerData = new PlayerDataCall();
            totalUsers = new TotalUsersCall();
        }

        public Task<BigInteger> EthBalance() => ethBalance.Call();

        public Task<GetHighestScorerOutputDTO> HighestScorer() => highestScorer.Call();

        public Task<GetOwnerOutputDTO> Owner() => owner.Call();

        public Task<GetPlayerDataOutputDTO> PlayerData() => playerData.Call();

        public Task<GetTotalUsersOutputDTO> TotalUsers() => totalUsers.Call();
    }
}