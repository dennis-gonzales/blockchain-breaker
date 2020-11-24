using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Ethereum.Wrapper
{
    [Function("getPlayerData", typeof(GetPlayerDataOutputDTO))]
    public class GetPlayerDataFunction : FunctionMessage
    {

    }

    [FunctionOutput]
    public class GetPlayerDataOutputDTO : IFunctionOutputDTO
    {
        [Parameter("bool", 1)]
        public bool IsActive { get; set; }

        [Parameter("string", 2)]
        public string Name { get; set; }

        [Parameter("uint256", 3)]
        public BigInteger HighScore { get; set; }

        [Parameter("uint256", 4)]
        public BigInteger LevelsCleared { get; set; }

        [Parameter("uint256", 5)]
        public BigInteger CurrentLevel { get; set; }

        public override string ToString()
        {
            return $"Is Active: {IsActive}";
        }
    }
}