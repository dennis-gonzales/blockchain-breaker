// SPDX-License-Identifier: MIT
pragma solidity 0.7.5;

contract BlockchainBreaker {
    
    struct Player {
        bool isActive;
        uint highscore;
        uint levelsCleared;
        uint currentLevel;
    }
    
    struct HighestScorer {
        uint score;
        address player;
    }

    mapping(address => Player) public players;
    HighestScorer public highestScorer;
    address public owner;
    uint public totalUsers;

    constructor() {
        owner = msg.sender;
    }
    
    function addPlayer() public {
        /*
            already active players
            can't add themselves again
        */
        require(players[msg.sender].isActive == false, "Already Added");
        
        Player memory newPlayer = Player({
            isActive: true,
            highscore: 0,
            levelsCleared: 0,
            currentLevel: 0
        });
        
        players[msg.sender] = newPlayer;
        totalUsers++;
    }
    
    function getPlayerData() public view returns(bool, uint, uint, uint) {
        Player storage playerData = players[msg.sender];
        
        return(
            playerData.isActive,
            playerData.highscore,
            playerData.levelsCleared,
            playerData.currentLevel
        );
    }
    
    function setScore(uint _newScore) public {    
        Player storage playerData = players[msg.sender];
        
        require(playerData.isActive == true, "Unauthorized");
        require(_newScore > 0, "Invalid Score Value");
        
        /*
            ignore the updatiion of value if the 
            _newScore and playerData.highscore is equal
            to lessen the cost of gas price
        */
        if (_newScore > playerData.highscore) {
            playerData.highscore = _newScore;
        }
        
        /*
            updates the highestScorer to the
            latest player that scored
        */
        if (_newScore >= highestScorer.score) {
            highestScorer.score = _newScore;
            highestScorer.player = msg.sender;
        }
    }
}