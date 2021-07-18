import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, } from 'rxjs';
import { map } from 'rxjs/operators';
import { Product } from '../model/product.model';
import { plainToClass } from 'class-transformer';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(
    private _http: HttpClient
  ) { }

  getProducts(): Observable<Product[]> {
    return this._http.get<Product[]>('http://localhost:5000/product')
      .pipe(map(x => plainToClass(Product, x)));
  }

}
