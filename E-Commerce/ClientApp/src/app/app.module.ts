import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeModule } from './entries/home/home.module';
import { ProductsModule } from './entries/products/products.module';
import { CartModule } from './entries/cart/cart.module';
import { SaleModule } from './entries/sale/sale.module';
import { NavigationComponent } from './shared/navigation/navigation.component';
import { NotFoundComponent } from './shared/not-found/not-found.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    NotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    HomeModule,
    ProductsModule,
    CartModule,
    SaleModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
