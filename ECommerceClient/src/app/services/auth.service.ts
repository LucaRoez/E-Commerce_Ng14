import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { BehaviorSubject } from "rxjs";
import { AuthCredentials } from '../entries/auth/interfaces/login-credentials';
import { FormGroup } from "@angular/forms";


@Injectable({
	providedIn: 'root'
})
export class AuthService {
	private loggedIn = new BehaviorSubject<boolean>(false);
	loggedIn$ = this.loggedIn.asObservable();

	constructor(private _router: Router) {}

	LogIn(newLogin: AuthCredentials): void {
		this.loggedIn.next(true);
		this.RedirectToHome();
	}

	LogOut(): void {
		this.loggedIn.next(false);
		this.RedirectToHome();
	}

	RedirectToHome(): void {
		this._router.navigate(['/']);
	}

	ExtractFormCredentials(formObject: FormGroup): AuthCredentials {
		let credentials: AuthCredentials = {
			name: formObject.value.name,
			presentation: formObject.value.presentation,
			email: formObject.value.email,
			password: formObject.value.password,
			confirmpass: formObject.value.confirmpass
		}
		return credentials;
	}
}