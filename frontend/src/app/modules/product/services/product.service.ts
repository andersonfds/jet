import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of, } from 'rxjs';
import { map } from 'rxjs/operators';
import { CartProduct, Product } from '../model/product.model';
import { plainToClass } from 'class-transformer';
import { LocalStorageService } from 'src/app/shared/services/local-storage.service';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private static readonly productsKey = 'product_ids';

  constructor(
    private readonly _http: HttpClient,
    private readonly _storage: LocalStorageService,
  ) { }

  getProducts(): Observable<Product[]> {
    return this._http.get<Product[]>('/product')
      .pipe(map(x => plainToClass(Product, x)));
  }

  getProductById(id: string): Observable<Product | null> {
    return this._http.get<Product>(`/product/${id}`)
      .pipe(
        map(x => plainToClass(Product, x)),
      );
  }

  getCart(): Observable<CartProduct[]> {
    return of(this.getCartProducts());
  }

  addProduct(product: CartProduct): boolean {
    // Getting current items on the cart
    let products = this.getCartProducts();
    // If adding an existing product it will
    // only change the quantity
    let savedProduct = products.find(x => x.product?.id == product.product?.id);
    if (savedProduct !== undefined) {
      let index = products.indexOf(savedProduct);
      let originalQuantity = savedProduct.quantity || 0;
      let sumQuantity = product.quantity || 1;
      let newQuantity = sumQuantity + originalQuantity;

      if (newQuantity <= 0)
        products.splice(index, 1);
      else
        products[index].quantity = sumQuantity + originalQuantity;
    } else
      // Appending the product
      products.push(product);

    // Overriding the product list
    this._storage.set(ProductService.productsKey, products);
    return true;
  }

  private getCartProducts(): CartProduct[] {
    let products = this._storage.getAs(ProductService.productsKey, CartProduct) || [];

    if (!(products instanceof Array))
      return [];

    return products;
  }

}
