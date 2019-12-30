export class Client {
    fullname :string;
    gender : number;
    lastVisit? : Date;
    createdAt : Date;
    id:string;
    phone? : string;
    email:string;
    constructor(id: string , fullname: string,gender: number,phone: string,email: string) {
        this.fullname = fullname;
        this.gender = gender;
        this.lastVisit = undefined;
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
