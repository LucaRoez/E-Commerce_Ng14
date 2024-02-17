import { Component } from '@angular/core';
import { Product } from '../../../models/models';
import { MainService } from '../../../services/main.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrl: './search.component.css'
})
export class SearchComponent {
  products: Product[] = [];
  constructor(private _http: MainService) {
    this._http.GetProducts().subscribe(
      result => this.products = result,
      error => console.error(error.error)
    )
  }
}
