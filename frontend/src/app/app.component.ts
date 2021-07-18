import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from './modules/product/model/product.model';
import { ProductService } from './modules/product/services/product.service';
import { State } from './shared/models/state.enum';

@Component({
  selector: 'app-root',
  template: `<router-outlet></router-outlet>`,
})
export class AppComponent {
}
