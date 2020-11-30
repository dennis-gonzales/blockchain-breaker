using System;
using System.Threading.Tasks;

namespace Ethereum.RPC.Deployment.Deployer
{
    public interface IDeployable<T>
    {
        Task<T> Deploy();
    }
}