using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Ethereum.Wrapper
{
    [Function("owner", typeof(GetOwnerOutputDTO))]
    public class GetOwnerFunction : FunctionMessage
    {

    }

    [FunctionOutput]
    public class GetOwnerOutputDTO : IFunctionOutputDTO
    {
        [Parameter("address", "owner")]
        public string Owner { get; set; }

        public override string ToString()
        {
            return $"Owner: {Owner}";
        }
    }
}