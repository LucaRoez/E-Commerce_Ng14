import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsComponent } from './products.component';
import { SearchComponent } from './search/search.component';
import { ProductComponent } from './product/product.component';
import { SearcherComponent } from './search/searcher/searcher.component';

import { MatSidenavModule } from '@angular/material/sidenav';
import { MatCardModule } from '@angular/material/card';

@NgModule({
  declarations: [
    ProductsComponent,
    SearchComponent,
    ProductComponent,
    SearcherComponent
  ],
  imports: [
    CommonModule,
    MatSidenavModule,
    MatCardModule
  ],
  exports: [
    ProductsComponent
  ]
})
export class ProductsModule { }
