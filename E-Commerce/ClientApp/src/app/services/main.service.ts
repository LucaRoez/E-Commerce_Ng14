import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Category, Currency, Gender } from "../models/models";

@Injectable({
  providedIn: 'root'
})
export class MainService {
  constructor(private _Http: HttpClient) {
  }    
  private url = 'https://localhost:7255/';

  GetGenders(): Observable<Gender[]> {
    return this._Http.get<Gender[]>(this.url + 'genders');
  }
    
  GetCategories(): Observable<Category[]> {
    return this._Http.get<Category[]>(this.url + 'categories');
  }
    
  GetCurrencies(): Observable<Currency[]> {
    return this._Http.get<Currency[]>(this.url + 'currencies');
  }
}