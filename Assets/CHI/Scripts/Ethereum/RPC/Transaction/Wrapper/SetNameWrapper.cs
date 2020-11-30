using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Ethereum.RPC.Transaction.Wrapper
{
    [Function("setPlayerName")]
    public class SetNameFunction : FunctionMessage
    {
        [Parameter("string", "_newName")]
        public virtual string NewName { get; set; }
    }
}