// SPDX-License-Identifier: MIT
pragma solidity 0.7.5;

contract BlockchainBreaker {
    
    event HighScoreAchieved(address _player, uint _newHighScore);
    
    struct Player {
        bool isActive;
        string name;
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

    modifier onlyActive {
        require(players[msg.sender].isActive == true, "Unauthorized");
        _;
    }

    constructor() {
        owner = msg.sender;
    }
    
    function addPlayer(string memory _playerName) public {
        require(players[msg.sender].isActive == false, "Already Added");
        
        Player memory newPlayer = Player({
            isActive: true,
            name: _playerName,
            highscore: 0,
            levelsCleared: 0,
            currentLevel: 0
        });
        
        players[msg.sender] = newPlayer;
        totalUsers++;
    }
    
    function setPlayerName(string memory _newName) public onlyActive {
        players[msg.sender].name = _newName;
    }
    
    function setPlayerScore(uint _newScore) public onlyActive {    
        require(_newScore > 0, "Invalid Score Value");
        
        /*
            ignore the updatiion of value if the 
            _newScore and playerData.highscore is equal
            to lessen the cost of gas price
        */
        if (_newScore > players[msg.sender].highscore) {
            players[msg.sender].highscore = _newScore;
        }
        
        /*
            updates the highestScorer to the
            latest player that scored
        */
        if (_newScore >= highestScorer.score) {
            highestScorer.score = _newScore;
            highestScorer.player = msg.sender;
            
            emit HighScoreAchieved(highestScorer.player, highestScorer.score);
        }
    }
    
    function getPlayerData() public view returns(bool, string memory, uint, uint, uint) {
        Player storage playerData = players[msg.sender];
        
        return(
            playerData.isActive,
            playerData.name,
            playerData.highscore,
            playerData.levelsCleared,
            playerData.currentLevel
        );
    }
}