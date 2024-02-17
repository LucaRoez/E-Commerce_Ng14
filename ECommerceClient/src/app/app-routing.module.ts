import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { NotFoundComponent } from './shared/not-found/not-found.component';
import { HomeComponent } from './entries/home/home.component';
import { SearchComponent } from './entries/products/search/search.component';
import { ProductComponent } from './entries/products/product/product.component';
import { SaleComponent } from './entries/sale/sale.component';
import { CartComponent } from './entries/cart/cart.component';
import { AdminComponent } from './entries/admin/admin.component';

const routes: Routes = [
  { path: '', pathMatch: "full", component: HomeComponent },
  { path: 'product-search', component: SearchComponent },
  { path: 'products/:id', component: ProductComponent },
  { path: 'cart', component: CartComponent },
  { path: 'checkout', component: SaleComponent },
  { path: 'admin', component: AdminComponent },
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
