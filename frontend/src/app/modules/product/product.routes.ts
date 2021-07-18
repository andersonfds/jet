import { Routes } from "@angular/router";
import { ProductDetailComponent } from "./views/product-detail/product-detail.component";
import { ProductListComponent } from "./views/product-list/product-list.component";

export const ProductRoutes : Routes = [
    {
        path: '',
        component: ProductListComponent,
    },
    {
        path: 'product/:productId',
        component: ProductDetailComponent,
    }
];