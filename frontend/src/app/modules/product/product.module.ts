import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductService } from './services/product.service';
import { HttpClientModule } from '@angular/common/http';
import { ProductListComponent } from './views/product-list/product-list.component';
import { RouterModule } from '@angular/router';
import { ProductRoutes } from './product.routes';
import { ProductDetailComponent } from './views/product-detail/product-detail.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { ProductCartComponent } from './views/product-cart/product-cart.component';



@NgModule({
  providers: [ProductService],
  declarations: [
    ProductListComponent,
    ProductDetailComponent,
    ProductCartComponent,
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    SharedModule,
    RouterModule.forChild(ProductRoutes),
  ],
})
export class ProductModule { }
