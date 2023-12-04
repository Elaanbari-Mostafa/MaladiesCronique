import { Injectable } from "@angular/core";
import Patient  from "../apis/patient";

@Injectable({
    providedIn: 'root'
})

export class PatientService {
    constructor() { }

    public GetAllPatinet(): Patient[] | any {
        
    }
}