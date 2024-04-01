import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Response } from "../models/models";

@Injectable({
  providedIn: 'root'
})
export class MainService {
  constructor(private _Http: HttpClient) {
  }    
  private url = 'https://localhost:7103/';

  GetProducts(): Observable<Response> {
    return this._Http.get<Response>(this.url + 'products');
  }
  
  GetProduct(id: number): Observable<Response> {
    return this._Http.get<Response>(this.url + 'products/' + id);
  }

  GetImages(): Observable<Response> {
    return this._Http.get<Response>(this.url + 'images');
  }

  GetImage(id: number): Observable<Response> {
    return this._Http.get<Response>(this.url + 'images/' + id);
  }

  GetGenders(): Observable<Response> {
    return this._Http.get<Response>(this.url + 'genders');
  }
    
  GetCategories(): Observable<Response> {
    return this._Http.get<Response>(this.url + 'categories');
  }
    
  GetCurrencies(): Observable<Response> {
    return this._Http.get<Response>(this.url + 'currencies');
  }

  GetAuthors(): Observable<Response> {
    return this._Http.get<Response>(this.url + 'authors');
  }
  
  GetAuthor(id: number): Observable<Response> {
    return this._Http.get<Response>(this.url + 'authors/' + id);
  }

  GetReviews(): Observable<Response> {
    return this._Http.get<Response>(this.url + 'reviews');
  }
  
  GetReview(id: number): Observable<Response> {
    return this._Http.get<Response>(this.url + 'reviews/' + id);
  }
}