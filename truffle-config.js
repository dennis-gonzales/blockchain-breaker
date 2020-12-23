module.exports = {

  contracts_directory: './src/ethereum/contracts/',
  contracts_build_directory: './src/ethereum/build/',
  migrations_directory: "./src/ethereum/migrations/",
  
  networks: {
    development: {
      host: "127.0.0.1",     // Localhost (default: none)
      port: 7545,            // Standard Ethereum port (default: none)
      network_id: "*",       // Any network (default: none)
     },
  },

  // Set default mocha options here, use special reporters etc.
  mocha: {
    // timeout: 100000
  },

  // Configure your compilers
  compilers: {
    solc: {
      version: "0.7.5"
    }
  }
};
