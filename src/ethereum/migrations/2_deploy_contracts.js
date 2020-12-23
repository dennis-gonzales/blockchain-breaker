const BlockchainBreaker = artifacts.require("BlockchainBreaker");
const Figure = artifacts.require("Figure");

module.exports = function (deployer) {
  deployer.deploy(BlockchainBreaker);
  deployer.deploy(Figure);
};
