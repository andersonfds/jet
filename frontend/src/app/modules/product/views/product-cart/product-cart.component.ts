import { Component, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { CartProduct, Product } from '../../model/product.model';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-cart',
  templateUrl: './product-cart.component.html',
  styleUrls: ['./product-cart.component.scss']
})
export class ProductCartComponent implements OnInit {

  products?: CartProduct[];

  constructor(private readonly _productService: ProductService) { }

  ngOnInit(): void {
    this.updateCart();
  }

  updateCart() {
    this._productService.getCart().subscribe((x) => this.products = x);
  }

  addItem(product: CartProduct) {
    var p = new CartProduct();
    p.product = product.product;
    this._productService.addProduct(p);
    this.updateCart();
  }

  removeItem(product: CartProduct) {
    var p = new CartProduct();
    p.product = product.product;
    p.quantity = -1;
    this._productService.addProduct(p);
    this.updateCart();
  }

}
