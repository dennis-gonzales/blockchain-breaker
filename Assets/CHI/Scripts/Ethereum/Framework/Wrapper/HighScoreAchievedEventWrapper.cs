using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Ethereum.Wrapper
{
    [Event("HighScoreAchieved")]
    public class HighScoreAchievedEventDTO : IEventDTO
    {
        [Parameter("address", "_player", 1)]
        public virtual string Player { get; set; }

        [Parameter("uint256", "_newHighScore", 2)]
        public virtual BigInteger NewHighScore { get; set; }
    }
}