using System.Threading.Tasks;

namespace Ethereum.RPC.Transaction
{
    public interface TransactionDataSource
    {
        Task<Response> AddPlayer();
        Task<Response> SetName();
        Task<Response> SetScore();
    }
}