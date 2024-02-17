import { Component } from '@angular/core';
import { Category, Currency, Gender, Product } from '../../../models/models';
import { AdminService, MainService } from '../../../services/services';

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
  
  responseMessage: string = '';
  isSuccess: boolean = false;
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
        this.responseMessage = 'Product published successfully.\n' + result;
        this.isSuccess = true;
      },
      error => {
        this.responseMessage = error.message;
        this.isSuccess = false;
        console.error('message: ' + error.message +
          '\nstatus: ' + error.status +
          '\nbody: ' + error.error)
      }   
    );
  }
}
