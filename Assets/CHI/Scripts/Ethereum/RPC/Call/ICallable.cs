using System;
using System.Threading.Tasks;

namespace Ethereum.RPC.Call
{
    public interface ICallable<T>
    {
        Task<T> Call();
    }
}