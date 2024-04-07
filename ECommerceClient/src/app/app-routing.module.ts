import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { NotFoundComponent } from './shared/not-found/not-found.component';
import { HomeComponent } from './entries/home/home.component';
import { SaleComponent } from './entries/sale/sale.component';
import { CartComponent } from './entries/cart/cart.component';
import { AdminComponent } from './entries/admin/admin.component';
import { isLoggedGuard } from './entries/auth/guards/is-logged.guard';

const routes: Routes = [
  { path: '', pathMatch: "full", component: HomeComponent },
  { path: 'cart', component: CartComponent },
  { path: 'checkout', component: SaleComponent },
  { path: 'admin', component: AdminComponent },
  { path: 'user', loadChildren: () => import('./entries/auth/user/user.module')
    .then(m => m.UserModule), canActivateChild: [isLoggedGuard], canLoad: [isLoggedGuard] },
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
