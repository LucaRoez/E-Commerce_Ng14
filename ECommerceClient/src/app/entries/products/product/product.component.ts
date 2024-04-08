import { Component } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { Product, ProductUI, Author, Review, Response } from '../../../models/models';
import { MainService, FunctionService } from '../../../services/services';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  productGot: Product = {
    name: '',
    description: ''
  };
  product: ProductUI = {
    name: '',
    description: '',
    isFirst: false, isLastThree: false
  };
  authors: Author[] | undefined = [];
  reviews: Review[] | undefined = [];
  response: Response = {
    isSuccessful: false,
    message: '',
    statusCode: 0
  };

  constructor(
    private _http: MainService, private _route: ActivatedRoute,
    private _router: Router,
    private _functions: FunctionService
  ) {
  }
  
  ngOnInit(): void {
    this._route.paramMap.subscribe((params: ParamMap) => {
      let id = params.get('id');
      if (id) {
        this._http.GetProduct(parseInt(id)).subscribe(response => {
          this.productGot = response.product!;
          this.product = { ...this.product, ...this.productGot };
          this._http.GetImage(this.productGot.presentationImageId ? this.productGot.presentationImageId : 0)
            .subscribe(response => {
              this.product =
                this._functions.SetImageToProduct(response.image ? response.image : null, this.product);
            }
          );
          if (this.product.linkedAuthors) {
            for (let author of this.product.linkedAuthors)
            {
              if (typeof author.id == 'number')
                this._http.GetAuthor(author.id).subscribe(response => {
                  if (typeof response.author != 'undefined')
                    this.authors?.push(response.author);
                },
                error => {
                  console.error(error);
                });
            }
          }
          if (this.product.linkedReviews)
            this._http.GetReviews().subscribe(response => {
              this.reviews = response.reviews;
            });
          this.response.isSuccessful = true;
          this.response.statusCode = response.statusCode;
          this.response.message = response.message;
        },
        error => {
          console.error(error);
          this.response.message = error;
        });
      }
    })

    if (this.productGot === null || this.productGot === undefined) {
      this._router.navigate(['product-search']);
    }
  }
}
