import { Routes } from "@angular/router";
import { ProductCartComponent } from "./views/product-cart/product-cart.component";
import { ProductDetailComponent } from "./views/product-detail/product-detail.component";
import { ProductListComponent } from "./views/product-list/product-list.component";

export const ProductRoutes: Routes = [
    {
        path: 'product',
        children: [
            {
                path: 'mycart',
                component: ProductCartComponent,
            },
            {
                path: ':productId',
                component: ProductDetailComponent,
            },
        ],
    },
    {
        path: '',
        component: ProductListComponent,
    },
];