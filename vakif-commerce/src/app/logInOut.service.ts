import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

@Injectable()
export class LogInOutService{

    signedIn: boolean = false;

    constructor(private httpClient: HttpClient, 
                private router: Router,
                @Inject('baseURL') private baseURL:string){}

    userLogIn(credentials: any){
        this.httpClient.post(this.baseURL+ "/Auth/Login", credentials).subscribe(
            response => {
            const token = (<any>response).Token;
            console.log(token);
            localStorage.setItem("jwt", token);
            this.signedIn = true;
            this.router.navigate(["en/home"]);
            }, 
            err => {this.signedIn = false;}
        );
    }

    userLogOut() {
        localStorage.removeItem("jwt");
        this.signedIn = false;
        this.router.navigate(["en/home"]);
      }
}