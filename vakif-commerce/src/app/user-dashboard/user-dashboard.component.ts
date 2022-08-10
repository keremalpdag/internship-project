import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { LogInOutService } from '../logInOut.service';

@Component({
  selector: 'app-user-dashboard',
  templateUrl: './user-dashboard.component.html',
  styleUrls: ['./user-dashboard.component.css']
})
export class UserDashboardComponent implements OnInit {
  
  signedIn: boolean;

  constructor(private logInOutService: LogInOutService) { }

  ngOnInit(): void {
    this.signedIn = this.logInOutService.signedIn;
    console.log(this.signedIn);
  }

  login(form: NgForm){
    const credentials = {
      'Email': form.value.email,
      'Password' : form.value.password
    }
    console.log(credentials);

    this.logInOutService.userLogIn(credentials); 
  }

  logout(){
    this.logInOutService.userLogOut();
  }
}
