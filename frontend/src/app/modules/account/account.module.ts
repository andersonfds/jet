import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AccountViewerComponent } from './views/account-viewer/account-viewer.component';
import { AccountSignupComponent } from './views/account-signup/account-signup.component';
import { RouterModule } from '@angular/router';
import { AccountRoutes } from './account.routes';
import { SharedModule } from 'src/app/shared/shared.module';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    AccountViewerComponent,
    AccountSignupComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    ReactiveFormsModule,
    RouterModule.forChild(AccountRoutes),
  ]
})
export class AccountModule { }
