pragma solidity ^0.4.8;

contract Greeter{
    address creator;
    string greeting;

    function Greeter(string _greeting) public{
        creator = msg.sender;
        greeting = _greeting;

    }

    function greet() constant returns(string){
        return greeting;
    }

    function setGreeting(string _newGreeting){
        greeting = _newGreeting;
    }

    function kill(){
        if(msg.sender == creator){
            suicide(creator);
        }
    }


}
