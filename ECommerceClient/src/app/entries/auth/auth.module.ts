import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatCardModule } from '@angular/material/card';
import { NgbAlert } from '@ng-bootstrap/ng-bootstrap';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';

import { AuthRoutingModule } from './auth-routing.module';
import { LogupComponent } from './logup/logup.component';
import { ReactiveFormsModule } from '@angular/forms';
import { FormExtensionsModule } from '../../shared/form-extentions/form-extensions.module';



@NgModule({
  declarations: [
    LogupComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MatCardModule,
    NgbAlert,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatSelectModule,
    FormExtensionsModule,
    AuthRoutingModule
  ],
  exports: [
    LogupComponent
  ]
})
export class AuthModule { }
