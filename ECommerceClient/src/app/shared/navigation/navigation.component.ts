import { Component } from '@angular/core';
import { AuthService } from '../../services/services';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrl: './navigation.component.css'
})
export class NavigationComponent {
  constructor(private _auth: AuthService) {}
  
  IsUserLogged$ = this._auth.loggedIn$;
}
