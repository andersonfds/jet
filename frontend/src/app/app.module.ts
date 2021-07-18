import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { AppRoutes } from './app.routes';
import { TokenInterceptor } from './interceptors/token.interceptor';
import { UrlInterceptor } from './interceptors/url.interceptor';
import { ProductModule } from './modules/product/product.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    ProductModule,
    RouterModule.forRoot(AppRoutes),
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: UrlInterceptor, multi: true },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
