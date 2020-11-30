using System;
using System.Threading.Tasks;

namespace Ethereum.RPC.Deployment
{
    public interface DeploymentDataSource
    {
        Task<Response> Web3Contract();
    }
}
