import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Image, Product, Response } from '../../../../models/models';
import { AdminService, MainService } from '../../../../services/services';

@Component({
  selector: 'app-link-image',
  templateUrl: './link-image.component.html',
  styleUrl: './link-image.component.css'
})
export class LinkImageComponent {
  constructor(private _PostService: AdminService, private _MainService: MainService) {}

  productTaken = {
    id: 0,
    name: ''
  };
  product!: Product | undefined;

  slots = [
    {
      value: 0,
      name: 'Presentation Image'
    },
    {
      value: 1,
      name: 'Second Image'
    },
    {
      value: 2,
      name: 'Third Image'
    },
    {
      value: 3,
      name: 'Fourth Image'
    },
    {
      value: 4,
      name: 'Fifth Image'
    },
    {
      value: 5,
      name: 'Sixth Image'
    }
  ]
  slotSelected = { name: 'Presentation Image', value: 0 };

  @Input() response!: Response;

  @Input() thisImage: Image | undefined = undefined;
  @Output() alertMessage = new EventEmitter<Response>();
  LinkImageToProduct(slot: number) {
    if (this.productTaken.id !== 0) {
      this._MainService.GetProduct(this.productTaken.id).subscribe(response => {
        this.product = response.product;
        this._MainService.GetImages().subscribe(result => {
          this.thisImage = result.images?.find(i => i.src === this.thisImage?.src);
        });
        this.response.isSuccessful = true;
      },
      error => {
        this.response.isSuccessful = false;
        this.response.message = error.message;
        this.response.statusCode = error.statusCode;
        this.alertMessage.emit(this.response);
      });
    }
    else {
      if (this.productTaken.name !== '') {
        const products = this._MainService.GetProducts();
        products.subscribe(search => {
          this.product = search.products?.find(p => p.name === this.productTaken.name);
          this._MainService.GetImages().subscribe(result => {
            this.thisImage = result.images?.find(i => i.src === this.thisImage?.src);
          });
          this.response.isSuccessful = true;
        },
        error => {
          this.response.isSuccessful = false;
          this.response.message = error.message;
          this.response.statusCode = error.statusCode;
          this.alertMessage.emit(this.response);
        });
      }
      else {
        this.response.isSuccessful = false;
        this.response.message = 'No inputs were loaded.'
        this.response.statusCode = 404;
        this.alertMessage.emit(this.response);
      }
    }
    if (this.response.isSuccessful == true) {
      this._PostService.adminLinkImage(this.thisImage, this.product, slot).subscribe(result => {
        this.response.message = 'Image linked successfully.\n' + result;
        this.response.statusCode = 200;
        this.alertMessage.emit(this.response);
      },
      error => {
        this.response.isSuccessful = false;
        this.response.message = error.message;
        this.response.statusCode = error.statusCode;
        this.alertMessage.emit(this.response);
      });
    }
  }
}