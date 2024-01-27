import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminComponent } from './admin.component';
import { FormsModule } from '@angular/forms';
import { CatalogsComponent } from './catalogs/catalogs.component';
import { ProductComponent } from './product/product.component';



@NgModule({
  declarations: [
    AdminComponent,
    CatalogsComponent,
    ProductComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports: [
    AdminComponent
  ]
})
export class AdminModule { }
