import { Component, OnInit } from '@angular/core';
import { Product, Image, ProductUI, Response } from '../../../models/models';
import { MainService, FunctionService } from '../../../services/services';
import { Router } from '@angular/router';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrl: './search.component.css'
})
export class SearchComponent implements OnInit {
  productsGot: Product[] = [];
  images: Image[] | undefined = [];
  products: ProductUI[] = [];
  constructor(private _http: MainService, private _router: Router, private _functions: FunctionService) {
  }

  response: Response = {
    isSuccessful: false,
    message: '',
    statusCode: 0
  }
  ngOnInit(): void {
    this._http.GetProducts().subscribe(
      response => {
        this.productsGot = response.products!;

        this.productsGot.map(p => {
          this.products.push(this._functions.PrepareProductToUI(p));
        });

        this._http.GetImages().subscribe(response => {
          this.images = response.images;
          let imagesFiltered: Image[] = this.images ? this.images.filter(i => i !== undefined) : [];
          this.products = this._functions.SetImagesToProducts(imagesFiltered, this.productsGot, this.products);
        },
        error => {
          console.error(error.message);
        });
    
        this.products.forEach((p, i) => {
          if (i == 0 || i % 3 == 0) {
            p.isFirst = true;
          }
        });    
        const lastThree = this.products.slice(-3);
        lastThree.map((p, i) => {
          p.isLastThree = true;
          this.products[this.products.length - 3 + i] = p;
        });
      },
      error => {
        this.response.isSuccessful = false,
        this.response.message = error.message,
        this.response.statusCode = error.statusCode,
        console.error(error.message),
        console.error(error.statusCode)
      }
    );
  }

  NavigateToProduct(product: Product): void {
    this._router.navigate(['product', product.id])
  }
}
