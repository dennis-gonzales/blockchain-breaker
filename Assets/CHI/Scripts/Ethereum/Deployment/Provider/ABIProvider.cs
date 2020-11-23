using System.IO;

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