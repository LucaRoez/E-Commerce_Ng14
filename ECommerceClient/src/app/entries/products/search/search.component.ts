import { Component, OnInit } from '@angular/core';
import { Product, Response } from '../../../models/models';
import { MainService } from '../../../services/main.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrl: './search.component.css'
})
export class SearchComponent implements OnInit {
  products: Product[] = [];
  constructor(private _http: MainService) {
  }

  response: Response = {
    isSuccessful: false,
    message: '',
    statusCode: 0
  }
  ngOnInit(): void {    
    this._http.GetProducts().subscribe(
      response => this.products = response.products!
    )
  }
}
