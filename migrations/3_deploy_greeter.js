var Greeter = artifacts.require("Greeter");

module.exports = function(deployer){
    deployer.deploy(Greeter, "Hello", {privateFor:["ROAZBWtSacxXQrOe3FGAqJDyJjFePR5ce4TSIzmJ0Bc="]});
}
