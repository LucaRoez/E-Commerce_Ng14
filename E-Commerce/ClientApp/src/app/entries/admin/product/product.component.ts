import { Component, OnInit } from '@angular/core';
import { Category, Currency, Gender, Product } from 'OpenApi/schema/models';
import { AdminService, MainService } from 'OpenApi/schema/services';
import { Observable, Subscription } from 'rxjs';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  constructor(private GetService: MainService, private PostService: AdminService) {
  }

  ngOnInit(): void {
    this.genderSuscription = this.GetAllGenders().subscribe(
      (genders: Gender[]) => { this.genders = genders },
      error => console.error(error.message)
    );
    this.categorySuscription = this.GetAllCategories().subscribe(
      (categories: Category[]) => { this.categories = categories },
      error => console.error(error.message)
    );
    this.currencySuscription = this.GetAllCurrencies().subscribe(
      (currencies: Currency[]) => { this.currencies = currencies },
      error => console.error(error.message)
    );
  }
  ngOnDestroy(): void {
    this.genderSuscription.unsubscribe();
    this.categorySuscription.unsubscribe();
    this.currencySuscription.unsubscribe();
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

  genders: Gender[] = []; genderSuscription: Subscription = new Subscription;
  GetAllGenders(): Observable<Gender[]> {
    return this.GetService.gendersPost();
  }
  categories: Category[] = []; categorySuscription: Subscription = new Subscription;
  GetAllCategories(): Observable<Category[]> {
    return this.GetService.categoriesPost();
  }
  currencies: Currency[] = []; currencySuscription: Subscription = new Subscription;
  GetAllCurrencies(): Observable<Currency[]> {
    return this.GetService.currenciesPost();
  }
}
