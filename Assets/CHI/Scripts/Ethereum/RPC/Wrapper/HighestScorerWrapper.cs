using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Ethereum.RPC.Wrapper
{

    [Function("highestScorer", typeof(GetHighestScorerOutputDTO))]
    public class GetHighestScorerFunction : FunctionMessage
    {

    }

    [FunctionOutput]
    public class GetHighestScorerOutputDTO : IFunctionOutputDTO
    {
        [Parameter("uint256", "score", 1)]
        public BigInteger Score { get; set; }

        [Parameter("address", "player", 2)]
        public string PlayerAddress { get; set; }

        public override string ToString()
        {
            // TODO: check if player address is indeed a correct ethereum address


            return $@"Player {PlayerAddress.Substring(0, 7)}...
                with the highest score of: {Score}";
        }
    }
}