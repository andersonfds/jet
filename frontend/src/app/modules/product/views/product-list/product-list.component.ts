import { Component, OnInit } from '@angular/core';
import { BehaviorSubject, from, Observable, of, Subscription } from 'rxjs';
import { catchError, distinctUntilChanged, map, share, shareReplay, switchMap } from 'rxjs/operators';
import { State } from 'src/app/shared/models/state.enum';
import { Product } from '../../model/product.model';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss']
})
export class ProductListComponent implements OnInit {
  // Subjects
  private productPageSubject: BehaviorSubject<number>;

  // Variables
  public StateEnum = State;
  public products: Product[] = [];
  public productState: State = State.loading;

  private pageSubscription?: Subscription;

  constructor(private _productService: ProductService) {
    this.productPageSubject = new BehaviorSubject<number>(1);
  }

  ngOnInit(): void {
    this.pageSubscription = this.productPageSubject.subscribe(page => this.loadProducts(page));
  }

  addToCart(product: Product) {
  }

  private loadProducts(page: number) {
    this.productState = State.loading;
    this._productService.getProducts().pipe()
      .subscribe(
        products => this.onProductsLoaded(products),
        () => this.onProductsErrorOccurred(),
      );
  }

  private onProductsErrorOccurred() {
    this.productState = State.error;
  }

  private onProductsLoaded(products: Product[]) {
    let hasData = products.length > 0;
    this.productState = hasData ? State.completed : State.empty;
    this.products = products;
  }
}
