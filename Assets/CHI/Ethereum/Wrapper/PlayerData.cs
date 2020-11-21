using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Ethereum.Wrapper
{
    public static class PlayerData
    {

        [Function("getPlayerData", typeof(GetPlayerDataOutputDTO))]
        public class GetPlayerDataFunction : FunctionMessage
        {

        }

        [FunctionOutput]
        public class GetPlayerDataOutputDTO : IFunctionOutputDTO
        {
            [Parameter("bool", "isActive", 1)]
            public bool IsActive { get; set; }


            [Parameter("uint256", "highscore", 2)]
            public BigInteger HighScore { get; set; }


            [Parameter("uint256", "levelsCleared", 3)]
            public BigInteger LevelsCleared { get; set; }


            [Parameter("uint256", "currentLevel", 4)]
            public BigInteger CurrentLevel { get; set; }
            

            public override string ToString()
            {
                return $"Is Active: {IsActive}";
            }
        }
    }
}
