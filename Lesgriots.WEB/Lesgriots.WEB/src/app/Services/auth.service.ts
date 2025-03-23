import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, tap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'http://localhost:8080/api/Auth'; // Remplace par l'URL de ton API

  constructor(private http: HttpClient) {}

  // login(credentials: { email: string; password: string }): Observable<{ token: string }> {
  //   return this.http.post<{ token: string }>(`${this.apiUrl}/login`, credentials).pipe(
  //     tap(response => {
  //       localStorage.setItem('token', response.token);
  //     })
  //   );
  // }
  login(credentials: { mail: string; password: string }): Observable<{ token: string }> {
    return this.http.post<{ token: string }>(`${this.apiUrl}/login`, credentials, {
      headers: { 'Content-Type': 'application/json', 'accept': '*/*' }
    }).pipe(
      tap(response => {
        localStorage.setItem('token', response.token);
      })
    );
  }
  logout(): void {
    localStorage.removeItem('token');
  }

  getToken(): string | null {
    
    if (typeof window !== 'undefined' && window.localStorage) {
      return localStorage.getItem('token');
    }else{
      return null;
    }
  }

  isAuthenticated(): boolean {
    return !!this.getToken();
  }
}
