import { Component, NgModule } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  public email: string = "mostafa";
  login(event:any){
    console.log(event);
  }
  
}
