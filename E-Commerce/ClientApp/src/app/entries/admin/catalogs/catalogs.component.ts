import { Component } from '@angular/core';
import { Category, Currency, Gender } from 'OpenApi/schema/models';
import { AdminService } from 'OpenApi/schema/services';

@Component({
  selector: 'app-catalogs',
  templateUrl: './catalogs.component.html',
  styleUrl: './catalogs.component.css'
})
export class CatalogsComponent {
  constructor(private http : AdminService){
  }

  responseMessage = '';
  GenderId: number = 0; GenderName: string = '';
  CategoryId: number = 0; CategoryName: string = '';
  CurrencyName: string = ''; CurrencySymbol: string = ''; CurrencyIssuer?: string = '';

  formBoxes: CatalogFormCard[] = [
    {
      responseMessage: '',
      formTitle: "Gender Category",
      responseStartsWith: "Gender category was send successfully",
      firstLabel: "Customizable ID",
      firstNgModel: this.GenderId,
      currencySymbol: '',
      secondLabel: "Gender Category Name",
      secondNgModel: this.GenderName,
      isThird: false,
      thirdLabel: '',
      thirdNgModel: '',
      buttonFunction: this.buttonFunction.bind(this),
      buttonLabel: "Gender Category"
    },
    {
      responseMessage: '',
      formTitle: "Clothing Category",
      responseStartsWith: "Clothing category was send successfully",
      firstLabel: "Customizable ID",
      firstNgModel: this.CategoryId,
      currencySymbol: '',
      secondLabel: "Clothing Category Name",
      secondNgModel: this.CategoryName,
      isThird: false,
      thirdLabel: '',
      thirdNgModel: '',
      buttonFunction: this.buttonFunction.bind(this),
      buttonLabel: "Clothing Category"
    },
    {
      responseMessage: '',
      formTitle: "Merchantable Currency",
      responseStartsWith: "New currency was successfully loaded",
      firstNgModel: 0,
      firstLabel: "Currency Symbol",
      currencySymbol: this.CurrencySymbol,
      secondLabel: "Currency Name",
      secondNgModel: this.CurrencyName,
      isThird: true,
      thirdLabel: 'Currency Issuer',
      thirdNgModel: this.CurrencyIssuer ?? '',
      buttonFunction: this.buttonFunction.bind(this),
      buttonLabel: "Clothing Category"
    }
  ];
  
  buttonFunction(formCard: CatalogFormCard) {
    switch (formCard.formTitle) {
      case "Gender Category": {
        const gender: Gender = { id: formCard.firstNgModel, name: formCard.secondNgModel };
        this.http.adminGenderPost({ body: gender }).subscribe(
          result => {
            formCard.responseMessage = "Gender category was send successfully to the server.\n" + result;
            formCard.firstNgModel = 0;
            formCard.secondNgModel = '';
          },
          error => (formCard.responseMessage = error.message)
        );
        break;
      }
      case "Clothing Category": {
        const category: Category = { id: formCard.firstNgModel, name: formCard.secondNgModel };
        this.http.adminCategoryPost({ body: category }).subscribe(
          result => {
            formCard.responseMessage = "Clothing category was send successfully to the server.\n" + result;
            formCard.firstNgModel = 0;
            formCard.secondNgModel = '';
          },
          error => (formCard.responseMessage = error.message)
        );
        break;
      }
      case "Merchantable Currency": {
        const currency: Currency = { name: formCard.secondNgModel, symbol: formCard.currencySymbol, issuer: formCard.thirdNgModel };
        this.http.adminCurrencyPost({ body: currency }).subscribe(
          result => {
            formCard.responseMessage = "New currency was successfully loaded to the server\n" + result;
            formCard.secondNgModel = '';
            formCard.currencySymbol = '';
            formCard.thirdNgModel = '';
          },
          error => (formCard.responseMessage = error.message)
        );
        break;
      }
      default: {
        console.error("Invalid form title:", formCard.formTitle);
        break;
      }
    }
  }
}

class CatalogFormCard {
  responseMessage: string = '';
  formTitle: string = '';
  responseStartsWith: string = '';
  firstLabel: string = '';
  firstNgModel: number = 0;
  currencySymbol: string = '';
  secondLabel: string = '';
  secondNgModel: string = '';
  isThird: boolean = false;
  thirdLabel: string = '';
  thirdNgModel: string = '';
  buttonFunction?: (formCard: CatalogFormCard) => void;
  buttonLabel: string = '';
}