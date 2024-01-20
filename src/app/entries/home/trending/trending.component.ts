import { Component } from '@angular/core';

@Component({
  selector: 'app-trending',
  templateUrl: './trending.component.html',
  styleUrl: './trending.component.css'
})
export class TrendingComponent {
  items: TrendingItems[] = [
    {
      src: "Super-Sexy-Work-Outfits-For-Modern-Women.png",
      alt: "sexy-work-woman-outfit",
      title: "Super Sexy Work Outfit for Modern Women",
      price: 350,
      discount: 436
    },
    {
      src: "Leather-Luxury-Handbags-Women.png",
      alt: "leather-luxury-handbag-for-woman",
      title: "Leather Luxury Women's Handbag",
      price: 110,
      discount: 169
    },
    {
      src: "Trendy-Outfit-Woman.png",
      alt: "trendy-woman-outfit",
      title: "Trendy Women's Outfit",
      price: 250,
      discount: 399
    },
    {
      src: "baby-trendy-tender-coat.png",
      alt: "baby-tender-coat",
      title: "Trendy Baby's Tender Coat",
      price: 120,
      discount: 210
    },
    {
      src: "men-casual-accessories.png",
      alt: "casual-man-outfit",
      title: "Trendy Casual Men's Outfit",
      price: 250,
      discount: 389
    },
    {
      src: "woman-boots-trendy.png",
      alt: "woman-boots-trendy",
      title: "Trendy Leather Wader Like Women's Boots",
      price: 130,
      discount: 199
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