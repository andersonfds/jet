import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-account-signup',
  templateUrl: './account-signup.component.html',
  styleUrls: ['./account-signup.component.scss']
})
export class AccountSignupComponent implements OnInit {

  passwordVisible: boolean = false;

  constructor() { }

  ngOnInit(): void {
  }

  switchPasswordVisibility() {
    this.passwordVisible = !this.passwordVisible;
  }

}
