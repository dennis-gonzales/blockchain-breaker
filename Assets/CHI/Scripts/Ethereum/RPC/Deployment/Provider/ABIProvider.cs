using System.IO;

namespace Ethereum.RPC.Deployment.Provider
{
    static class ABIProvider
    {
        public static string Read()
        {
            string abiPath = "bin/Contract/BlockchainBreaker.abi";

            using (StreamReader reader = new StreamReader(abiPath))
            {
                return reader.ReadToEnd();
            }
        }
    }
}