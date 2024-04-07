import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatCardModule } from '@angular/material/card';
import { NgbAlert } from '@ng-bootstrap/ng-bootstrap';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';

import { AuthRoutingModule } from './auth-routing.module';
import { LoginComponent } from './login/login.component';



@NgModule({
  declarations: [
    LoginComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    NgbAlert,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatSelectModule,
    AuthRoutingModule
  ],
  exports: [
    LoginComponent
  ]
})
export class AuthModule { }
