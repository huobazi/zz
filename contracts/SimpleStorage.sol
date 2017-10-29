pragma solidity ^0.4.8

contract SimpleStorage{
    unit public storeData;

    function SipleStorage(unit initVal){
        storeData = initVal;
    }

    function set(unit m){
       storeData = m;
    }

    function get() constant returns(unit retVal){
       return storeData;
    }
}
