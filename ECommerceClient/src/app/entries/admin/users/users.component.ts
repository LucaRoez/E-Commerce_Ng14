import { Component, OnInit } from '@angular/core';
import { Author, Response } from '../../../models/models'
import { MainService, AdminService } from '../../../services/services'

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrl: './users.component.css'
})
export class UsersComponent implements OnInit {
  constructor(private _GetService: MainService, private _PostService: AdminService) {
  }
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
  
  author: Author = {
    authorName: '',
    email: ''
  }
  response: Response = {
    message: '',
    isSuccessful: false,
    statusCode: 0
  }

  PublishAuthor(author: Author): void {

  }
}
