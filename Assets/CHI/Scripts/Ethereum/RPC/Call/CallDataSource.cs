using Ethereum.RPC.Call.Wrapper;
using System.Numerics;
using System.Threading.Tasks;

namespace Ethereum.RPC.Call
{
    public interface CallDataSource
    {
        Task<BigInteger> EthBalance();
        Task<GetHighestScorerOutputDTO> HighestScorer();
        Task<GetOwnerOutputDTO> Owner();
        Task<GetPlayerDataOutputDTO> PlayerData();
        Task<GetTotalUsersOutputDTO> TotalUsers();
    }
}