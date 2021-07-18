import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { State } from 'src/app/shared/models/state.enum';
import { Product } from '../../model/product.model';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss']
})
export class ProductListComponent implements OnInit {

  public StateEnum = State;
  product$: Observable<Product[]> = this._productService.getProducts();
  productState: State = State.loading;

  constructor(private _productService: ProductService) {
  }

  ngOnInit(): void {
    this.getProducts();
  }

  addToCart(product: Product) {
  }

  private getProducts() {
    this.product$.subscribe(
      (p) => this.productState = p.length > 0 ? State.completed : State.empty,
      () => this.productState = State.error,
    );
  }
}
