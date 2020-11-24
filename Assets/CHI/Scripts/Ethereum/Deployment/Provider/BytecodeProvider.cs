using System.IO;

namespace Ethereum.Deployment.Deployer.Provider
{
    static class BytecodeProvider
    {
        public static string Read()
        {
            string bytecodePath = "bin/Contract/BlockchainBreaker.bin";

            using (StreamReader reader = new StreamReader(bytecodePath))
            {
                return reader.ReadToEnd();
            }
        }
    }
}