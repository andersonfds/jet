import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AccountSignupRequestDto } from '../views/models/account-signup.request.dto';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  constructor(private http: HttpClient) { }

  create(account: AccountSignupRequestDto): Observable<void> {
    return this.http.post<void>('/user', account);
  }
}
