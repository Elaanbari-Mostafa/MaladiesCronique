import { AuthService } from './../../../services/auth.service';
import { HttpService } from './../../../services/http-services/http.service';
import { Component, NgModule } from '@angular/core';
import { MessageService } from 'primeng/api';
import { HttpErrorResponse } from '@angular/common/http';
import { Router } from '@angular/router';
import { DataService } from 'src/app/configs/dataService';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
  providers: [MessageService],
})
export class LoginComponent {
  email: string = "";
  password: string = "";
  constructor(private dataService: DataService,private authServie: AuthService, private messageService: MessageService,private router:Router) { }

  async login() {

    try {
      const response = await this.authServie.loginWithEmailAndPassword(this.email, this.password).toPromise();
      this.messageService.add({ severity: 'success', summary: 'Success', detail: 'Connexion réussie' });
      localStorage.setItem("_profile", JSON.stringify(response.token));
      this.dataService.updateData("true");
      this.router.navigate(['/']).then(() => {
        window.location.reload();
      });
    } catch (error: HttpErrorResponse | any) {
      this.dataService.updateData("false");
      switch (error.status) {
        case 404:
          this.messageService.add({ severity: 'error', summary: 'Error', detail: `${error.error}` });
          break;

        default:
          break;
      }

    }

  }
}
