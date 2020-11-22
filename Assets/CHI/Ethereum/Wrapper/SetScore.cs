using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Ethereum.Wrapper
{
    [Function("setScore")]
    public class SetScoreFunction : FunctionMessage
    {
        [Parameter("uint256", "_newScore", 1)]
        public virtual BigInteger NewScore { get; set; }
    }
}