import { Injectable } from '@angular/core';
import {  CanActivate, CanActivateChild, CanLoad, Router, UrlTree } from '@angular/router';
import { AuthService } from '../../../services/auth.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class isLoggedGuard implements CanActivate, CanActivateChild, CanLoad {
  constructor(private _auth: AuthService, private _router: Router) {}

  canLoad(): Observable<true | UrlTree> {
    return this.IsLogged();
  }

  canActivateChild(): Observable<true | UrlTree> {
    return this.IsLogged();
  }

  canActivate(): Observable<true | UrlTree> {
    return this.IsLogged();
  }

  private IsLogged(): Observable<true | UrlTree> {    
    return this._auth.loggedIn$.pipe(
      map(logged => logged || this._router.parseUrl('/login'))
    );
  }
};
