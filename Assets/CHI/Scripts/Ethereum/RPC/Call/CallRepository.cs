using Ethereum.RPC.Call.UseCase;
using System.Numerics;
using System.Threading.Tasks;

namespace Ethereum.RPC.Call
{
    public class CallRepository : CallDataSource
    {
        private EthBalanceCall ethBalance;
        private HighestScorerCall highestScorer;
        private OwnerCall owner;
        private PlayerDataCall playerData;
        private TotalUsersCall totalUsers;

        public CallRepository()
        {
            ethBalance = new EthBalanceCall();
            highestScorer = new HighestScorerCall();
            owner = new OwnerCall();
            playerData = new PlayerDataCall();
            totalUsers = new TotalUsersCall();
        }

        public Task<BigInteger> EthBalance() => ethBalance.Call();

        public Task<string> HighestScorer() => highestScorer.Call();

        public Task<string> Owner() => owner.Call();

        public Task<string> PlayerData() => playerData.Call();

        public Task<int> TotalUsers() => totalUsers.Call();
    }
}