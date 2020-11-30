using System;
using System.Threading.Tasks;

namespace Ethereum.RPC.Transaction
{
    public interface ITransactable<T>
    {
        Task<T> Transact();
    }
}