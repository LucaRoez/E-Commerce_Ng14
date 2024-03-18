import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ProductsComponent } from './products.component';
import { SearchComponent } from './search/search.component';
import { ProductComponent } from './product/product.component';
import { SearcherComponent } from './search/searcher/searcher.component';

import { MatSidenavModule } from '@angular/material/sidenav';
import { MatCardModule } from '@angular/material/card';
import { MatSliderModule } from '@angular/material/slider';
import { MatListModule } from '@angular/material/list';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    ProductsComponent,
    SearchComponent,
    ProductComponent,
    SearcherComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule,
    MatSidenavModule,
    MatCardModule,
    MatSliderModule,
    MatListModule,
    NgbDropdownModule
  ],
  exports: [
    ProductsComponent
  ]
})
export class ProductsModule { }
