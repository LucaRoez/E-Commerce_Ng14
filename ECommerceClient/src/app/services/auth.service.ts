import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { BehaviorSubject } from "rxjs";


@Injectable({
    providedIn: 'root'
})
export class AuthService {
    private loggedIn = new BehaviorSubject<boolean>(false);
    loggedIn$ = this.loggedIn.asObservable();

    constructor(private _router: Router) {}

    LogIn(): void {
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
}