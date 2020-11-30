using System;
using System.Threading.Tasks;
using Ethereum.RPC.Transaction.UseCase;

namespace Ethereum.RPC.Transaction
{
    public class TransactionRepository : TransactionDataSource
    {
        private readonly AddPlayerTransaction addPlayer;
        private readonly SetNameTransaction setName;
        private readonly SetScoreTransaction setScore;

        public TransactionRepository()
        {
            addPlayer = new AddPlayerTransaction();
            setName = new SetNameTransaction();
            setScore = new SetScoreTransaction();
        }

        public Task<Response> AddPlayer() => addPlayer.Transact();

        public Task<Response> SetName() => setName.Transact();

        public Task<Response> SetScore() => setScore.Transact();
    }
}