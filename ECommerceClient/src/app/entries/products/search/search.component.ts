import { Component, OnInit } from '@angular/core';
import { Product, Response } from '../../../models/models';
import { MainService } from '../../../services/main.service';
import { Router } from '@angular/router'

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrl: './search.component.css'
})
export class SearchComponent implements OnInit {
  products: Product[] = [];
  constructor(private _http: MainService, private _router: Router) {
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

  NavigateToProduct(product: Product): void {
    this._router.navigate(['product', product.id])
  }
}
