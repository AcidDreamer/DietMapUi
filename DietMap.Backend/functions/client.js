class Client {
    constructor(id, fullname,gender) {
        this.fullname = fullname;
        this.gender = gender;
        this.lastVisit = null;
        this.createdAt = new Date();
        this.id = id;
    }
}

module.exports = {
    Client : Client
};