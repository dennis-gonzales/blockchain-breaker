using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Ethereum.Wrapper
{
    [Function("addPlayer")]
    public class AddPlayerFunction : FunctionMessage
    {
        [Parameter("string", "_playerName")]
        public virtual string PlayerName { get; set; }
    }
}