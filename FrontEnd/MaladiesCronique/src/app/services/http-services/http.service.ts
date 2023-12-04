import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class HttpService {
  private readonly apiUrl = 'https://jsonplaceholder.typicode.com/todos';

  constructor(private http: HttpClient) { }

  // GET request
  get(endpoint: string): Observable<any> {
    return this.http.get(`${this.apiUrl}/${endpoint}`);
  }

  // POST request
  post(endpoint: string, data: any): Observable<any> {
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

}
