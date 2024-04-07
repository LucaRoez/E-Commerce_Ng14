import { Component } from '@angular/core';
import { Author, Response } from '../../../models/models'
import { MainService, AdminService, AuthService } from '../../../services/services'
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  constructor(private _GetService: MainService, private _PostService: AdminService, private _auth: AuthService) {
  }

  author: Author = {
    authorName: '',
    email: ''
  }
  response: Response = {
    message: '',
    isSuccessful: false,
    statusCode: 0
  }
  formControl = new FormControl({
    name: new FormControl(''),
    presentation: new FormControl(''),
    email: new FormControl(''),
    password: new FormControl(''),
    confirmpass: new FormControl('')
  });

  PublishAuthor(author: Author): void {
    const authCredentials = this.formControl.value;
    this._auth.LogIn();
  }
}
