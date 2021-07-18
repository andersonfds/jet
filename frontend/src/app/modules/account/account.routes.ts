import { Routes } from "@angular/router";
import { AccountSignupComponent } from "./views/account-signup/account-signup.component";

export const AccountRoutes: Routes = [
    {
        path: 'sign-up',
        component: AccountSignupComponent,
    },
];