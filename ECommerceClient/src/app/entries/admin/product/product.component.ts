import { Component, OnInit } from '@angular/core';
import { Category, Currency, Gender, Product, Response } from '../../../models/models';
import { AdminService, MainService } from '../../../services/services';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent implements OnInit {
  constructor(private _GetService: MainService, private _PostService: AdminService) {
  }

  ngOnInit(): void {
    this._GetService.GetGenders().subscribe(
      response => {
        this.genders = response.genders!;
      }
    )
    this._GetService.GetCategories().subscribe(
      response => {
        this.categories = response.categories!;
      }
    )
    this._GetService.GetCurrencies().subscribe(
      response => {
        this.currencies = response.currencies!;
      }
    )
  }

  genders: Gender[] = []; genderId: number | null = null;
  categories: Category[] = []; categoryId: number | null = null;
  currencies: Currency[] = []; currencyId: number | null = null;

  product: Product = {
    categoryId: 0,
    name: '',
    description: '',
    price: null,
    currencyId: null,
    discount: null,
    genderId: 0,
    quantityAvailable: null
  };
  
  response: Response = {
    message: '',
    isSuccessful: false,
    statusCode: 0
  }
  PublishProduct(productSent: Product) {
    const newProduct: Product = {
      name: productSent.name,
      description: productSent.description,
      price: productSent.price,
      currencyId: this.currencyId,
      discount: productSent.discount,
      genderId: this.genderId,
      categoryId: this.categoryId,
      quantityAvailable: productSent.quantityAvailable
    };
    this._PostService.adminProductPost(newProduct).subscribe(
      result => {
        this.response.message = 'Product published successfully.\n' + result;
        this.response.isSuccessful = true;
      },
      error => {
        this.response.message = error.message;
        this.response.isSuccessful = false;
        this.response.statusCode = error.status;
        console.error('message: ' + error.message +
          '\nstatus: ' + error.status +
          '\nbody: ' + error.error)
      }   
    );
  }
}
