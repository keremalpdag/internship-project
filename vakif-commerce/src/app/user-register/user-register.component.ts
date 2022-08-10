import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { RegisterService } from '../register.service';
@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrls: ['./user-register.component.css']
})
export class UserRegisterComponent implements OnInit {

  constructor(private registerService: RegisterService) { }

  ngOnInit(): void {}

  register(form : NgForm){
    const registerInformation = {
      'FirstName' : form.value.firstName,
      'LastName' : form.value.lastName,
      'Email' : form.value.email,
      'Password' : form.value.password
    }

    this.registerService.registerUser(registerInformation);
  }
}
