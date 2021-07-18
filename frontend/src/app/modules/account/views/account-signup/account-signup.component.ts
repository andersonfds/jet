import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { plainToClass } from 'class-transformer';
import { ErrorResponse } from 'src/app/shared/models/error.interface';
import { AccountService } from '../../services/account.service';
import { AccountSignupRequestDto } from '../models/account-signup.request.dto';

@Component({
  selector: 'app-account-signup',
  templateUrl: './account-signup.component.html',
  styleUrls: ['./account-signup.component.scss']
})
export class AccountSignupComponent implements OnInit {

  signupForm?: FormGroup;
  passwordVisible: boolean = false;
  errorMessage?: string;
  isLoading = false;

  constructor(
    private readonly fb: FormBuilder,
    private readonly _accountService: AccountService,
  ) { }

  ngOnInit(): void {
    this.signupForm = this.fb.group({
      name: [null, Validators.compose([Validators.required])],
      email: [null, Validators.compose([Validators.required, Validators.email])],
      password: [null, Validators.compose([Validators.required, Validators.minLength(6)])],
      phone: [null, Validators.required],
    });
  }

  switchPasswordVisibility() {
    this.passwordVisible = !this.passwordVisible;
  }

  onSignup() {
    let accountRequest = plainToClass(AccountSignupRequestDto, this.signupForm?.getRawValue());
    this.isLoading = true;
    this._accountService.create(accountRequest).subscribe(
      () => this.redirect(),
      (e) => this.error(e),
    );
  }

  private error(e: HttpErrorResponse) {
    let error: ErrorResponse = e.error;
    this.isLoading = false;
    this.errorMessage = error.errors[0].message;
  }

  private redirect() {
    this.isLoading = false;
  }

  get hasError(): boolean {
    return this.errorMessage != null;
  }

}
