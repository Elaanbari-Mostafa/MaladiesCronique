import { HttpService } from './http-services/http.service';
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})

export class AuthService {
    constructor(private http: HttpService) { }

    public loginWithEmailAndPassword(email: string, password: string) {
        var response = this.http.post("LoginByEmailAndPassword", { Email: email, MotDePasse: password });
        // localStorage.setItem("_Profile",String.toString(response));
        return response;
    }

}