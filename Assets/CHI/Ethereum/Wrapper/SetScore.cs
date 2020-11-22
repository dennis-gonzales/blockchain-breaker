using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Ethereum.Wrapper
{
    [Function("setPlayerScore")]
    public class SetScoreFunction : FunctionMessage
    {
        [Parameter("uint256", "_newScore")]
        public virtual BigInteger NewScore { get; set; }
    }
}