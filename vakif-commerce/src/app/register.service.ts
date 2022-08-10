import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Router } from "@angular/router";


@Injectable()
export class RegisterService{

    registered: boolean;

    constructor(private httpClient: HttpClient, 
        private router: Router,
        @Inject('baseURL') private baseURL:string){}
        
    registerUser(registerInformation: any){
        this.httpClient.post(this.baseURL+ "/Auth/Register", registerInformation).subscribe(
            response => {
            const token = (<any>response).Token;
            console.log(token);
            localStorage.setItem("jwt", token);
            this.registered = true;
            this.router.navigate(["en/home"]);
            }, 
            err => {this.registered = false;}
        );
    }
}