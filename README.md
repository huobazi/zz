# ZZ
This is a quorum && truffle/solidity && nethereum  demo project

## Usage

### Step1

see also: https://github.com/jpmorganchase/quorum-examples

```
git clone https://github.com/jpmorganchase/quorum-examples
```

then change the VM's network settings to

```
config.vm.network "public_network", ip: "10.11.12.88", bridge: "en1: Wi-Fi (AirPort)"

```

then


```
cd quorum-examples
vagrant up

vagrant ssh
cd quorum-examples/7nodes/
init.sh
start.sh
```

### Step2

```
cd truffle_example
truffle compile
truffle migrate
truffle console
```

### Step3

```
cd nethereum_quorum_example/ConsoleExample
dotnet run
```
