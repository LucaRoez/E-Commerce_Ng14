import { Component } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { Product } from '../../../models/models';
import { MainService } from '../../../services/main.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  constructor(private _http: MainService, private _route: ActivatedRoute, private _router: Router) {}

  product: Product = {
    name: '',
    description: ''
  };
  
  ngOnInit(): void {
    this._route.paramMap.subscribe((params: ParamMap) => {
      let id = params.get('id');
      if (id) {
        this._http.GetProduct(parseInt(id)).subscribe(response => this.product = response.product!);
      }
    })

    if (this.product === null || this.product === undefined) {
      this._router.navigate(['product-search']);
    }
  }
}
