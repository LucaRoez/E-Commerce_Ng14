import { Component, OnInit } from '@angular/core';
import { Product } from 'OpenApi/schema/models';
import { AdminService, MainService } from 'OpenApi/schema/services';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  constructor(private GetService: MainService, private PostService: AdminService) {
  }

  ngOnInit(): void {

  }

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

    this.PostService.adminProductPost({ body: newProduct }).subscribe(
      result => {
        this.responseMessage = "Product published successfully.\n" + result;
        this.isSuccess = true;

      },
      error => { this.responseMessage = error.message; }
    )
  }

  GetAllCatalogs() {
    this.GetService.
  }
}
