using System.Numerics;
using System.Threading.Tasks;

namespace Ethereum.RPC.Call
{
    public interface CallDataSource
    {
        Task<BigInteger> EthBalance();
        Task<string> HighestScorer();
        Task<string> Owner();
        Task<string> PlayerData();
        Task<int> TotalUsers();
    }
}