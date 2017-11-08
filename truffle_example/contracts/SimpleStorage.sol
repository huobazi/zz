pragma solidity ^0.4.8;

contract SimpleStorage{
    uint public storedData;

    function SimpleStorage(uint initVal){
        storedData = initVal;
    }

    function set(uint newVal){
       storedData = newVal;
    }

    function get() constant returns(uint retVal){
       return storedData;
    }
}
