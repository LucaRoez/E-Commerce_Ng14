import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Category, Currency, Gender, Product, Image, Response } from "../models/models";
import { Observable } from "rxjs";

const httpOp = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable()
export class AdminService {
  constructor(private _Http: HttpClient) {
  }
  private url = 'https://localhost:7103/admin/';

  adminGenderPost(gender: Gender): Observable<Response> {
    return this._Http.post<Response>(this.url + 'gender', gender, httpOp);
  }

  adminCategoryPost(category: Category): Observable<Response> {
    return this._Http.post<Response>(this.url + 'category', category, httpOp);
  }

  adminCurrencyPost(currency: Currency): Observable<Response> {
    return this._Http.post<Response>(this.url + 'currency', currency, httpOp);
  }

  adminProductPost(product: Product): Observable<Response> {
    return this._Http.post<Response>(this.url + 'product', product, httpOp);
  }

  adminImagePost(image: Image): Observable<Response> {
    return this._Http.post<Response>(this.url + 'image', image, httpOp);
  }

  adminLinkImage(image: Image | undefined, product: Product | undefined, slot: number): Observable<Response> {
    return this._Http.post<Response>(this.url + 'link-image', {image, product, slot}, httpOp);
  }
}