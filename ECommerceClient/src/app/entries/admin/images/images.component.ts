import { Component } from '@angular/core';
import { AdminService } from '../../../services/admin.service';
import { Image, Response } from '../../../models/models'

@Component({
  selector: 'app-images',
  templateUrl: './images.component.html',
  styleUrl: './images.component.css'
})
export class ImagesComponent {
  constructor(private _PostService: AdminService) {}

  image: Image = {
    id: 0,
    src: '',
    alt: '',
    height: 0,
    width: 0
  };

  response: Response = {
    message: '',
    isSuccessful: false,
    statusCode: 0
  }
  PublishImage(imageSent: Image) {
    const newImage: Image = {
      id: 0,
      src: imageSent.src,
      alt: imageSent.alt,
      height: imageSent.height,
      width: imageSent.width
    };
    this._PostService.adminImagePost(newImage).subscribe(
      result => {
        this.response.message = 'Image published successfully.\n' + result;
        this.response.isSuccessful = true;
      },
      error => {
        this.response.message = error.message;
        this.response.isSuccessful = false;
        this.response.statusCode = error.status;
        console.error('message: ' + error.message +
          '\nstatus: ' + error.status +
          '\nbody: ' + error.error)
      }
    );
  }
}
