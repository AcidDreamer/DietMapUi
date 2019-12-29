class Client {
    constructor(id, fullname,gender,phone,email) {
        this.fullname = fullname;
        this.gender = gender;
        this.lastVisit = null;
        this.createdAt = new Date();
        this.id = id;
        if (phone){
            this.phone = phone;
        }else {this.phone = "";}
        if (email){
            this.email = email;
        }else {this.email = "";}
    }
}

module.exports = {
    Client : Client
};