import { Component } from '@angular/core';

@Component({
  selector: 'trending',
  templateUrl: './trending.component.html',
  styleUrl: './trending.component.css'
})
export class TrendingComponent {
  items: TrendingItems[] = [
    {
      src: "",
      alt: "",
      title: "",
      price: 0,
      discount: 0
    },
    {
      src: "",
      alt: "",
      title: "",
      price: 0,
      discount: 0
    },
    {
      src: "",
      alt: "",
      title: "",
      price: 0,
      discount: 0
    },
    {
      src: "",
      alt: "",
      title: "",
      price: 0,
      discount: 0
    },
    {
      src: "",
      alt: "",
      title: "",
      price: 0,
      discount: 0
    },
    {
      src: "",
      alt: "",
      title: "",
      price: 0,
      discount: 0
    }
  ]
}

class TrendingItems
{
  src: string = "";
  alt: string = "";
  title: string = "";
  price: number = 0;
  discount: number = 0;
}