module.exports = {
    networks: {
        development: {
            host: "localhost",
            port: 22000,
            network_id: "*", // Match any network id
        },
        node4: {
            host: "localhost",
            port: 22003, // as voter,
            network_id: "*", // Match any network id
        },
        node7: {
            host: "localhost",
            port: 22006,
            network_id: "*", // Match any network id
        }
    }
};
