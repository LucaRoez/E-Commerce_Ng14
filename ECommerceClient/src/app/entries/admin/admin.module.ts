import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { AdminComponent } from './admin.component';
import { CatalogsComponent } from './catalogs/catalogs.component';
import { ProductComponent } from './product/product.component';

import { MatTabsModule } from '@angular/material/tabs';
import { MatCardModule } from '@angular/material/card';
import { NgbAlert } from '@ng-bootstrap/ng-bootstrap';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { ImagesComponent } from './images/images.component';
import { AdminService } from '../../services/admin.service';
import { LinkImageComponent } from './images/link-image/link-image.component';
import { UsersComponent } from './users/users.component';


@NgModule({
  declarations: [
    AdminComponent,
    CatalogsComponent,
    ProductComponent,
    ImagesComponent,
    LinkImageComponent,
    UsersComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    MatTabsModule,
    MatCardModule,
    NgbAlert,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatSelectModule
  ],
  exports: [
    AdminComponent
  ],
  providers: [
    AdminService
  ]
})
export class AdminModule { }
