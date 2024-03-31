import { Component, ViewChild, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SearchComponent } from './search/search.component';
import { ProductComponent } from './product/product.component';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent implements OnInit {
  constructor(private router: Router) {}

  currentInput!: string;
  backInput!: string;
  isSearch!: boolean;
  @ViewChild(SearchComponent) search!: SearchComponent;
  @ViewChild(ProductComponent) product!: ProductComponent;

  ngOnInit(): void {    
    this.isSearch = this.router.url.includes('product-search') ? true : false;
    this.currentInput = this.isSearch ? "Category" : "Product Detail";
    this.backInput = this.isSearch ? "Home" : "Category";
  }
  
  GetClicked(input: string) {
    if (input === this.backInput) {
      let route: string = this.backInput === "Home" ? '' : 'product-search';
      this.router.navigate([route]);
    }
    else {
      this.router.navigate([this.router.url]);
    }
  }
}
