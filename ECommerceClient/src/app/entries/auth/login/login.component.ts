import { Component } from '@angular/core';
import { Author, Response } from '../../../models/models'
import { MainService, AdminService, AuthService } from '../../../services/services'
import { FormControl, FormGroup, Validators } from '@angular/forms';

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
  formControl = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(3), Validators.maxLength(20)]),
    presentation: new FormControl('', [Validators.maxLength(50)]),
    email: new FormControl('', [Validators.required, Validators.maxLength(80), Validators.email]),
    password: new FormControl('', [Validators.required, Validators.pattern("^(?=.*[!#$%&*-+.,_])(?=.*\\d)(?=.*[A-Z]).*$"), Validators.maxLength(50)]),
    confirmpass: new FormControl('', [Validators.required, Validators.pattern("^(?=.*[!#$%&*-+.,_])(?=.*\\d)(?=.*[A-Z]).*$"), Validators.maxLength(50)])
  });

  get nameControl(): FormControl { return this.formControl.get('name') as FormControl }
  get presentationControl(): FormControl { return this.formControl.get('presentation') as FormControl }
  get emailControl(): FormControl { return this.formControl.get('email') as FormControl }
  get passControl(): FormControl { return this.formControl.get('password') as FormControl }
  get confirmControl(): FormControl { return this.formControl.get('confirmpass') as FormControl }

  PublishAuthor(): void {
    const formObject = this.formControl;
    this._auth.LogIn(this._auth.ExtractFormCredentials(formObject));
  }
}
