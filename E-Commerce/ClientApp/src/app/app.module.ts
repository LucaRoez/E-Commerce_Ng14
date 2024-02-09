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
import { AdminModule } from './entries/admin/admin.module';
import { GlobalDialogsComponent } from './shared/global-dialogs/global-dialogs.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AdminService, MainService } from './services/services';

@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    NotFoundComponent,
    GlobalDialogsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    HomeModule,
    ProductsModule,
    CartModule,
    SaleModule,
    AdminModule,
    BrowserAnimationsModule
  ],
  providers: [
    MainService,
    AdminService,
    { provide: 'BASE_URL', useValue: 'https://localhost:7255.com' }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
