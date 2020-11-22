﻿using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace Ethereum.Wrapper
{
    public static class TotalUser
    {

        [Function("totalUsers", typeof(GetTotalUsersOutputDTO))]
        public class GetTotalUsersFunction : FunctionMessage
        {

        }

        [FunctionOutput]
        public class GetTotalUsersOutputDTO : IFunctionOutputDTO
        {
            [Parameter("uint256", "totalUsers")]
            public BigInteger TotalUsers { get; set; }

            public override string ToString()
            {
                return $"Total Users: {TotalUsers}";
            }
        }
    }
}
