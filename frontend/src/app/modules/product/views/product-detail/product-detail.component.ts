import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { filter, map, switchMap } from 'rxjs/operators';
import { State } from 'src/app/shared/models/state.enum';
import { CartProduct, Product } from '../../model/product.model';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.scss']
})
export class ProductDetailComponent implements OnInit {

  private productId$ = this._activatedRoute.paramMap.pipe(map(x => x.get('productId')));
  productState: State = State.loading;
  product?: Product | null;


  constructor(
    private readonly _productService: ProductService,
    private readonly _activatedRoute: ActivatedRoute,
  ) { }

  ngOnInit(): void {
    this.productId$.subscribe((id: any) => this.getProductById(id));
  }

  private getProductById(id: string) {
    this._productService.getProductById(id)
      .subscribe(x => this.product = x);
  }

  addToCart() {
    if (this.product) {
      let cartProduct = new CartProduct();
      cartProduct.product = this.product;
      this._productService.addProduct(cartProduct);
    }
  }

}
