import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { catchError, map, Observable, throwError } from 'rxjs';
import { MessageService } from 'primeng/api';

@Injectable({
  providedIn: 'root',
})

export class HttpService {
  private readonly apiUrl = 'http://localhost:5172';

  constructor(private http: HttpClient) { }

  // GET request
  get(endpoint: string): Observable<any> {
    return this.http.get(`${this.apiUrl}/${endpoint}`);
  }

  // POST request
  post(endpoint: string, data: any): Observable<any>{
      return this.http.post(`${this.apiUrl}/${endpoint}`, data);
  }

  // PUT request
  put(endpoint: string, data: any): Observable<any> {
    return this.http.put(`${this.apiUrl}/${endpoint}`, data);
  }

  // DELETE request
  delete(endpoint: string): Observable<any> {
    return this.http.delete(`${this.apiUrl}/${endpoint}`);
  }

  private handleError(error: HttpErrorResponse) {
    console.log('An error occurred:', error.error);
    //this.messageService.add({ severity: 'success', summary: 'Success', detail: 'Message Content' });

    return throwError(() => new Error('Something went wrong; please try again later.'));
  }

}
