import { Routes } from "@angular/router";

export const AppRoutes: Routes  = [
    {
        path: '',
        loadChildren: () => import('./modules/product/product.module').then(m => m.ProductModule),
    }
];