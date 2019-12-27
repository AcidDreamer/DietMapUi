class Client {
    // public DateTime CreatedAt { get; set; }
    // public DateTime LastVisit { get; set; }
    // public string Id { get; set; }
    // public string FullName {get;set;}
    lastVisit :number;
    createdAt :number;
    fullname: string;
    public constructor(fullname : string) {
        this.fullname = fullname;
        this.createdAt = new Date().getTime();
        this.lastVisit = 0;
    }
}
