class Client {
    constructor(id, fullname) {
        this.fullname = fullname;
        this.lastVisit = null;
        this.createdAt = new Date();
        this.id = id;
    }
}

module.exports = {
    Client : Client
};