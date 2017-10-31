module.exports = {
    networks: {
        node1: {
            host: "localhost",
            port: 22000, // was 8545,
            network_id: "*" // Match any network id
        },
        node4: {
            host: "localhost",
            port: 22003, // was 8545,
            network_id: "*" // Match any network id
        },
        node7: {
            host: "localhost",
            port: 22006, // was 8545,
            network_id: "*" // Match any network id
        }
    }
};
