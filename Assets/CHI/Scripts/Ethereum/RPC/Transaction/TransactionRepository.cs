using System;
using System.Threading.Tasks;
using Ethereum.RPC.Transaction.UseCase;

namespace Ethereum.RPC.Transaction
{
    public class TransactionRepository : TransactionDataSource
    {
        private readonly Lazy<AddPlayerTransaction> addPlayer;
        private readonly Lazy<SetNameTransaction> setName;
        private readonly Lazy<SetScoreTransaction> setScore;

        public TransactionRepository()
        {
            addPlayer = new Lazy<AddPlayerTransaction>();
            setName = new Lazy<SetNameTransaction>();
            setScore = new Lazy<SetScoreTransaction>();
        }

        public Task<Response> AddPlayer() => addPlayer.Value.Transact();

        public Task<Response> SetName() => setName.Value.Transact();

        public Task<Response> SetScore() => setScore.Value.Transact();
    }
}