import { Component } from '@angular/core';
import { Category, Currency, Gender, Product } from 'src/app/models/models';
import { AdminService, MainService } from 'src/app/services/services';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  constructor(private _GetService: MainService, private _PostService: AdminService) {
    this._GetService.GetGenders().subscribe(
      result => { this.genders = result; },
      error => { console.error(error) }
    )
    this._GetService.GetCategories().subscribe(
      result => { this.categories = result; },
      error => { console.error(error) }
    )
    this._GetService.GetCurrencies().subscribe(
      result => { this.currencies = result; },
      error => { console.error(error) }
    )
  }

  genders: Gender[] = [];
  categories: Category[] = [];
  currencies: Currency[] = [];

  product: Product = {
    categoryId: 0,
    name: '',
    description: '',
    price: 0,
    currencyId: 0,
    discount: 0,
    genderId: 0,
    quantityAvailable: 0
  };
  
  responseMessage: string = '';
  isSuccess: boolean = false;
  PublishProduct(productSent: Product) {
    const newProduct: Product = {
      name: productSent.name,
      description: productSent.description,
      price: productSent.price,
      currencyId: productSent.categoryId,
      discount: productSent.discount,
      genderId: productSent.genderId,
      categoryId: productSent.categoryId,
      quantityAvailable: productSent.quantityAvailable
    }
  }
}
