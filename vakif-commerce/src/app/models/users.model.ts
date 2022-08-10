export class Users{

    public Id: number;
    public FirstName: string;
    public LastName: string;
    public Email: string;
    public Status: string;
    public PasswordSalt: string;
    public PasswordHash: string;

    constructor(Id: number, FirstName: string, LastName: string, Email: string, Status: string, PasswordSalt: string, PasswordHash: string){
        this.Id = Id;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Email = Email;
        this.Status = Status;
        this.PasswordSalt = PasswordSalt;
        this.PasswordHash = PasswordHash;
    }
}