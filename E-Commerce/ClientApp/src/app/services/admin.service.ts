import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Category, Currency, Gender } from "../models/models";
import { Observable } from "rxjs";

const httpOp = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
    providedIn: 'root'
})
export class AdminService {
  constructor(private _Http: HttpClient) {
  }
  private url = 'https://localhost:7255/admin/';
  
  adminGenderPost(gender: Gender): Observable<Gender> {
    return this._Http.post<Gender>(this.url + 'gender', httpOp);
  }

  adminCategoryPost(category: Category): Observable<Category> {
    return this._Http.post<Category>(this.url + 'category', httpOp);
  }

  adminCurrencyPost(currency: Currency): Observable<Currency> {
    return this._Http.post<Currency>(this.url + 'currency', httpOp)
  }
}