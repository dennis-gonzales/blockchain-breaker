using Ethereum.RPC.Call;
using Ethereum.RPC.Transaction;
using UnityEngine;

namespace Ethereum.Singleton
{
    public class Chitereum : MonoBehaviour
    {

        private static Chitereum _instance;
        public static Chitereum instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<Chitereum>();

                    if (_instance == null)
                    {
                        _instance = new GameObject().AddComponent<Chitereum>();
                    }
                }

                return _instance;
            }
        }

        private void Awake()
        {
            if (_instance != null)
            {
                Destroy(this);
            }
            else
            {
                DontDestroyOnLoad(this);
                CallDataSource = new CallRepository();
                TransactionDataSource = new TransactionRepository();
            }
        }

        public CallDataSource CallDataSource { get; private set; }
        public TransactionDataSource TransactionDataSource { get; private set; }
    }
}